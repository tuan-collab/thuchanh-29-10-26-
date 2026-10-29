using System.Data;
using System.Data.SqlClient;
using HotelManagement.DTO;

namespace HotelManagement.DAL
{
    public class PhongDAL
    {
        // Sử dụng mô hình Disconnected Model nạp danh sách phòng
        public DataTable GetDataTablePhong()
        {
            string query = "SELECT SoPhong, LoaiPhong, GiaTheoGio, TrangThai FROM Phong";
            return DatabaseAccess.ExecuteQuery(query);
        }

        public bool UpdateTrangThaiPhong(string soPhong, string trangThai)
        {
            string query = "UPDATE Phong SET TrangThai = @TrangThai WHERE SoPhong = @SoPhong";
            SqlParameter[] p = {
                new SqlParameter("@TrangThai", trangThai),
                new SqlParameter("@SoPhong", soPhong)
            };
            return DatabaseAccess.ExecuteNonQuery(query, p) > 0;
        }
    }
}