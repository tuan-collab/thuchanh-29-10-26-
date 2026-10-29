using System;
using System.Data;
using System.Data.SqlClient;
using HotelManagement.DTO;

namespace HotelManagement.DAL
{
    public class KhachHangDAL
    {
        // Tra cứu khách hàng theo CCCD dùng SqlParameter
        public KhachHangDTO GetKhachHangByCCCD(string cccd)
        {
            string query = "SELECT * FROM KhachHang WHERE CCCD = @CCCD";
            SqlParameter[] p = { new SqlParameter("@CCCD", cccd) };
            DataTable dt = DatabaseAccess.ExecuteQuery(query, p);

            if (dt.Rows.Count > 0)
            {
                DataRow row = dt.Rows[0];
                return new KhachHangDTO
                {
                    MaKH = Convert.ToInt32(row["MaKH"]),
                    HoTen = row["HoTen"].ToString(),
                    CCCD = row["CCCD"].ToString(),
                    SoDienThoai = row["SoDienThoai"].ToString()
                };
            }
            return null;
        }

        public int InsertKhachHang(KhachHangDTO kh)
        {
            string query = "INSERT INTO KhachHang (HoTen, CCCD, SoDienThoai) OUTPUT INSERTED.MaKH VALUES (@HoTen, @CCCD, @SoDienThoai)";
            SqlParameter[] p = {
                new SqlParameter("@HoTen", kh.HoTen),
                new SqlParameter("@CCCD", kh.CCCD),
                new SqlParameter("@SoDienThoai", (object)kh.SoDienThoai ?? DBNull.Value)
            };
            return Convert.ToInt32(DatabaseAccess.ExecuteScalar(query, p));
        }
    }
}