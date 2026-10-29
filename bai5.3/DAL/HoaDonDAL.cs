using System;
using System.Data;
using System.Data.SqlClient;
using Microsoft.Data.SqlClient;

namespace CafePOS
{
    public class HoaDonDAL
    {
        public int GetUnpaidHoaDonByBan(int maBan)
        {
            string query = "SELECT MaHoaDon FROM HoaDon WHERE MaBan = @MaBan AND TrangThai = 0";
            SqlParameter[] p = { new SqlParameter("@MaBan", maBan) };
            object res = DatabaseAccess.ExecuteQuery(query, p);
            return res != null ? Convert.ToInt32(res) : -1;
        }

        public DataTable GetBillDetailsByHoaDon(int maHoaDon)
        {
            string query = @"
                SELECT m.TenMon AS [Tên Món], ct.SoLuong AS [Số Lượng], 
                       ct.DonGia AS [Đơn Giá], (ct.SoLuong * ct.DonGia) AS [Thành Tiền]
                FROM ChiTietHoaDon ct 
                JOIN MonAn m ON ct.MaMon = m.MaMon 
                WHERE ct.MaHoaDon = @MaHoaDon";
            SqlParameter[] p = { new SqlParameter("@MaHoaDon", maHoaDon) };
            return DatabaseAccess.ExecuteQuery(query, p);
        }

        public bool AddMonToHoaDon(int maBan, int maMon, int soLuong, decimal donGia, ref int maHoaDon)
        {
            using (SqlConnection conn = DatabaseAccess.GetConnection())
            {
                conn.Open();
                SqlTransaction trans = conn.BeginTransaction();
                try
                {
                    if (maHoaDon == -1)
                    {
                        string insertHD = "INSERT INTO HoaDon (MaBan, GioVao, TrangThai) OUTPUT INSERTED.MaHoaDon VALUES (@MaBan, GETDATE(), 0)";
                        SqlCommand cmdHD = new SqlCommand(insertHD, conn, trans);
                        cmdHD.Parameters.AddWithValue("@MaBan", maBan);
                        maHoaDon = (int)cmdHD.ExecuteScalar();

                        string updateBan = "UPDATE BanAn SET TrangThai = N'Có khách' WHERE MaBan = @MaBan";
                        SqlCommand cmdBan = new SqlCommand(updateBan, conn, trans);
                        cmdBan.Parameters.AddWithValue("@MaBan", maBan);
                        cmdBan.ExecuteNonQuery();
                    }

                    string checkCT = "SELECT SoLuong FROM ChiTietHoaDon WHERE MaHoaDon = @MaHD AND MaMon = @MaMon";
                    SqlCommand cmdCheck = new SqlCommand(checkCT, conn, trans);
                    cmdCheck.Parameters.AddWithValue("@MaHD", maHoaDon);
                    cmdCheck.Parameters.AddWithValue("@MaMon", maMon);
                    object result = cmdCheck.ExecuteScalar();

                    if (result != null)
                    {
                        int currentQty = Convert.ToInt32(result);
                        string updateCT = "UPDATE ChiTietHoaDon SET SoLuong = @SoLuong WHERE MaHoaDon = @MaHD AND MaMon = @MaMon";
                        SqlCommand cmdUpdateCT = new SqlCommand(updateCT, conn, trans);
                        cmdUpdateCT.Parameters.AddWithValue("@SoLuong", currentQty + soLuong);
                        cmdUpdateCT.Parameters.AddWithValue("@MaHD", maHoaDon);
                        cmdUpdateCT.Parameters.AddWithValue("@MaMon", maMon);
                        cmdUpdateCT.ExecuteNonQuery();
                    }
                    else
                    {
                        string insertCT = "INSERT INTO ChiTietHoaDon (MaHoaDon, MaMon, SoLuong, DonGia) VALUES (@MaHD, @MaMon, @SoLuong, @DonGia)";
                        SqlCommand cmdInsertCT = new SqlCommand(insertCT, conn, trans);
                        cmdInsertCT.Parameters.AddWithValue("@MaHD", maHoaDon);
                        cmdInsertCT.Parameters.AddWithValue("@MaMon", maMon);
                        cmdInsertCT.Parameters.AddWithValue("@SoLuong", soLuong);
                        cmdInsertCT.Parameters.AddWithValue("@DonGia", donGia);
                        cmdInsertCT.ExecuteNonQuery();
                    }

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

        public bool ThanhToanHoaDon(int maHoaDon, int maBan, out decimal tongTien)
        {
            tongTien = 0;
            using (SqlConnection conn = DatabaseAccess.GetConnection())
            {
                conn.Open();
                SqlTransaction trans = conn.BeginTransaction();
                try
                {
                    string sumQuery = "SELECT ISNULL(SUM(SoLuong * DonGia), 0) FROM ChiTietHoaDon WHERE MaHoaDon = @MaHD";
                    SqlCommand cmdSum = new SqlCommand(sumQuery, conn, trans);
                    cmdSum.Parameters.AddWithValue("@MaHD", maHoaDon);
                    tongTien = Convert.ToDecimal(cmdSum.ExecuteScalar());

                    string updateHD = @"UPDATE HoaDon 
                                       SET GioRa = GETDATE(), TongTien = @TongTien, TrangThai = 1 
                                       WHERE MaHoaDon = @MaHD";
                    SqlCommand cmdHD = new SqlCommand(updateHD, conn, trans);
                    cmdHD.Parameters.AddWithValue("@TongTien", tongTien);
                    cmdHD.Parameters.AddWithValue("@MaHD", maHoaDon);
                    cmdHD.ExecuteNonQuery();

                    string updateBan = "UPDATE BanAn SET TrangThai = N'Trống' WHERE MaBan = @MaBan";
                    SqlCommand cmdBan = new SqlCommand(updateBan, conn, trans);
                    cmdBan.Parameters.AddWithValue("@MaBan", maBan);
                    cmdBan.ExecuteNonQuery();

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