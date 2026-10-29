using System.Data;
using System.Data.SqlClient;
using Microsoft.Data.SqlClient;
namespace CafePOS
{
    public class MonAnDAL
    {
        public DataTable GetAllMonAn()
        {
            string query = @"SELECT m.MaMon, m.TenMon, d.TenDanhMuc, m.DonGia, m.MaDanhMuc 
                            FROM MonAn m 
                            JOIN DanhMuc d ON m.MaDanhMuc = d.MaDanhMuc";
            return DatabaseAccess.ExecuteQuery(query);
        }

        public DataTable GetDanhMuc()
        {
            return DatabaseAccess.ExecuteQuery("SELECT * FROM DanhMuc");
        }

        public DataTable GetMonByDanhMuc(int maDanhMuc)
        {
            string query = "SELECT * FROM MonAn WHERE MaDanhMuc = @MaDM";
            SqlParameter[] p = { new SqlParameter("@MaDM", maDanhMuc) };
            return DatabaseAccess.ExecuteQuery(query, p);
        }

        public bool InsertMonAn(string tenMon, int maDanhMuc, decimal donGia)
        {
            string query = "INSERT INTO MonAn (TenMon, MaDanhMuc, DonGia) VALUES (@TenMon, @MaDanhMuc, @DonGia)";
            SqlParameter[] p = {
                new SqlParameter("@TenMon", tenMon),
                new SqlParameter("@MaDanhMuc", maDanhMuc),
                new SqlParameter("@DonGia", donGia)
            };
            return DatabaseAccess.ExecuteQuery(query, p) != null;
        }

        public bool UpdateMonAn(int maMon, string tenMon, int maDanhMuc, decimal donGia)
        {
            string query = "UPDATE MonAn SET TenMon = @TenMon, MaDanhMuc = @MaDanhMuc, DonGia = @DonGia WHERE MaMon = @MaMon";
            SqlParameter[] p = {
                new SqlParameter("@MaMon", maMon),
                new SqlParameter("@TenMon", tenMon),
                new SqlParameter("@MaDanhMuc", maDanhMuc),
                new SqlParameter("@DonGia", donGia)
            };
            return DatabaseAccess.ExecuteQuery(query, p) != null;
        }

        public bool DeleteMonAn(int maMon)
        {
            string query = "DELETE FROM MonAn WHERE MaMon = @MaMon";
            SqlParameter[] p = { new SqlParameter("@MaMon", maMon) };
            return DatabaseAccess.ExecuteQuery(query, p) != null;
        }
    }
}