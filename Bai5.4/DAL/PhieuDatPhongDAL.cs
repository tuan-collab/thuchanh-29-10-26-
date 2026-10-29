using System;
using System.Data;
using System.Data.SqlClient;
using HotelManagement.DTO;

namespace HotelManagement.DAL
{
    public class PhieuDatPhongDAL
    {
        public int GetActivePhieuBySoPhong(string soPhong)
        {
            string query = "SELECT MaPhieu FROM PhieuDatPhong WHERE SoPhong = @SoPhong AND NgayTraPhong IS NULL";
            SqlParameter[] p = { new SqlParameter("@SoPhong", soPhong) };
            object res = DatabaseAccess.ExecuteScalar(query, p);
            return res != null ? Convert.ToInt32(res) : -1;
        }

        public bool CheckIn(int maKH, string soPhong)
        {
            using (SqlConnection conn = DatabaseAccess.GetConnection())
            {
                conn.Open();
                using (SqlTransaction trans = conn.BeginTransaction())
                {
                    try
                    {
                        // 1. Lập phiếu nhận phòng
                        string insertPhieu = "INSERT INTO PhieuDatPhong (SoPhong, MaKH, NgayNhanPhong) VALUES (@SoPhong, @MaKH, GETDATE())";
                        SqlCommand cmdPhieu = new SqlCommand(insertPhieu, conn, trans);
                        cmdPhieu.Parameters.AddWithValue("@SoPhong", soPhong);
                        cmdPhieu.Parameters.AddWithValue("@MaKH", maKH);
                        cmdPhieu.ExecuteNonQuery();

                        // 2. Chuyển trạng thái phòng sang "Đang ở"
                        string updatePhong = "UPDATE Phong SET TrangThai = N'Đang ở' WHERE SoPhong = @SoPhong";
                        SqlCommand cmdPhong = new SqlCommand(updatePhong, conn, trans);
                        cmdPhong.Parameters.AddWithValue("@SoPhong", soPhong);
                        cmdPhong.ExecuteNonQuery();

                        trans.Commit();
                        return true;
                    }
                    catch
                    {
                        trans.Rollback();
                        throw;
                    }
                }
            }
        }

        public bool AddSuDungDichVu(SuDungDichVuDTO sd)
        {
            string query = "INSERT INTO SuDungDichVu (MaPhieu, MaDV, SoLuong, ThoiGian) VALUES (@MaPhieu, @MaDV, @SoLuong, GETDATE())";
            SqlParameter[] p = {
                new SqlParameter("@MaPhieu", sd.MaPhieu),
                new SqlParameter("@MaDV", sd.MaDV),
                new SqlParameter("@SoLuong", sd.SoLuong)
            };
            return DatabaseAccess.ExecuteNonQuery(query, p) > 0;
        }

        public DataTable GetSuDungDichVuByPhieu(int maPhieu)
        {
            string query = @"
                SELECT dv.TenDV, sd.SoLuong, dv.DonGia, (sd.SoLuong * dv.DonGia) AS ThanhTien, sd.ThoiGian
                FROM SuDungDichVu sd
                JOIN DichVu dv ON sd.MaDV = dv.MaDV
                WHERE sd.MaPhieu = @MaPhieu";
            SqlParameter[] p = { new SqlParameter("@MaPhieu", maPhieu) };
            return DatabaseAccess.ExecuteQuery(query, p);
        }

        // Thực thi Check-out & Xuất Hóa Đơn trong 1 SqlTransaction
        public bool CheckOut(int maPhieu, string soPhong, out decimal tongTienCalculated)
        {
            tongTienCalculated = 0;
            using (SqlConnection conn = DatabaseAccess.GetConnection())
            {
                conn.Open();
                using (SqlTransaction trans = conn.BeginTransaction())
                {
                    try
                    {
                        // 1. Lấy thông tin giờ nhận và giá giờ
                        string queryInfo = @"
                            SELECT pdp.NgayNhanPhong, p.GiaTheoGio 
                            FROM PhieuDatPhong pdp 
                            JOIN Phong p ON pdp.SoPhong = p.SoPhong 
                            WHERE pdp.MaPhieu = @MaPhieu";
                        SqlCommand cmdInfo = new SqlCommand(queryInfo, conn, trans);
                        cmdInfo.Parameters.AddWithValue("@MaPhieu", maPhieu);

                        DateTime ngayNhan = DateTime.Now;
                        decimal giaTheoGio = 0;
                        using (SqlDataReader reader = cmdInfo.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                ngayNhan = Convert.ToDateTime(reader["NgayNhanPhong"]);
                                giaTheoGio = Convert.ToDecimal(reader["GiaTheoGio"]);
                            }
                        }

                        // Tính số giờ ở (Tối thiểu 1 giờ, làm tròn lên)
                        TimeSpan span = DateTime.Now - ngayNhan;
                        int soGio = (int)Math.Ceiling(span.TotalHours);
                        if (soGio <= 0) soGio = 1;
                        decimal tienPhong = soGio * giaTheoGio;

                        // 2. Tính tổng tiền dịch vụ
                        string queryDV = "SELECT ISNULL(SUM(sd.SoLuong * dv.DonGia), 0) FROM SuDungDichVu sd JOIN DichVu dv ON sd.MaDV = dv.MaDV WHERE sd.MaPhieu = @MaPhieu";
                        SqlCommand cmdDV = new SqlCommand(queryDV, conn, trans);
                        cmdDV.Parameters.AddWithValue("@MaPhieu", maPhieu);
                        decimal tienDichVu = Convert.ToDecimal(cmdDV.ExecuteScalar());

                        tongTienCalculated = tienPhong + tienDichVu;

                        // 3. Cập nhật NgayTraPhong và TongTienThanhToan
                        string updatePhieu = "UPDATE PhieuDatPhong SET NgayTraPhong = GETDATE(), TongTienThanhToan = @TongTien WHERE MaPhieu = @MaPhieu";
                        SqlCommand cmdUpdatePhieu = new SqlCommand(updatePhieu, conn, trans);
                        cmdUpdatePhieu.Parameters.AddWithValue("@TongTien", tongTienCalculated);
                        cmdUpdatePhieu.Parameters.AddWithValue("@MaPhieu", maPhieu);
                        cmdUpdatePhieu.ExecuteNonQuery();

                        // 4. Chuyển trạng thái phòng sang "Đang dọn dẹp"
                        string updatePhong = "UPDATE Phong SET TrangThai = N'Đang dọn dẹp' WHERE SoPhong = @SoPhong";
                        SqlCommand cmdUpdatePhong = new SqlCommand(updatePhong, conn, trans);
                        cmdUpdatePhong.Parameters.AddWithValue("@SoPhong", soPhong);
                        cmdUpdatePhong.ExecuteNonQuery();

                        trans.Commit();
                        return true;
                    }
                    catch
                    {
                        trans.Rollback();
                        throw;
                    }
                }
            }
        }
    }
}