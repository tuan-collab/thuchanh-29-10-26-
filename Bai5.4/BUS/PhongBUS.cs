using System.Data;
using HotelManagement.DAL;

namespace HotelManagement.BUS
{
    public class PhongBUS
    {
        private PhongDAL phongDAL = new PhongDAL();

        public DataTable GetDataTablePhong() => phongDAL.GetDataTablePhong();
        public bool UpdateTrangThai(string soPhong, string trangThai) => phongDAL.UpdateTrangThaiPhong(soPhong, trangThai);
    }
}