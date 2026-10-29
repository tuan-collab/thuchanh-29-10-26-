using System.Data;

namespace CafePOS
{
    public class HoaDonBUS
    {
        private HoaDonDAL hoaDonDAL = new HoaDonDAL();

        public int GetUnpaidHoaDonByBan(int maBan) => hoaDonDAL.GetUnpaidHoaDonByBan(maBan);

        public DataTable GetBillDetailsByHoaDon(int maHoaDon) => hoaDonDAL.GetBillDetailsByHoaDon(maHoaDon);

        public bool AddMonToHoaDon(int maBan, int maMon, int soLuong, decimal donGia, ref int maHoaDon)
        {
            return hoaDonDAL.AddMonToHoaDon(maBan, maMon, soLuong, donGia, ref maHoaDon);
        }

        public bool ThanhToanHoaDon(int maHoaDon, int maBan, out decimal tongTien)
        {
            return hoaDonDAL.ThanhToanHoaDon(maHoaDon, maBan, out tongTien);
        }
    }
}