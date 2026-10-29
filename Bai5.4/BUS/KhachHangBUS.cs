using HotelManagement.DAL;
using HotelManagement.DTO;

namespace HotelManagement.BUS
{
    public class KhachHangBUS
    {
        private KhachHangDAL khachHangDAL = new KhachHangDAL();

        public KhachHangDTO FindByCCCD(string cccd) => khachHangDAL.GetKhachHangByCCCD(cccd);

        public int AddKhachHang(KhachHangDTO kh, out string error)
        {
            error = string.Empty;
            if (string.IsNullOrWhiteSpace(kh.HoTen))
            {
                error = "Họ tên không được để trống!";
                return -1;
            }
            if (string.IsNullOrWhiteSpace(kh.CCCD))
            {
                error = "Số CCCD không được để trống!";
                return -1;
            }
            return khachHangDAL.InsertKhachHang(kh);
        }
    }
}