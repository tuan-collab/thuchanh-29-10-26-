namespace CafePOS
{
    public class ChiTietHoaDonDTO
    {
        public int MaHoaDon { get; set; }
        public int MaMon { get; set; }
        public int SoLuong { get; set; }
        public decimal DonGia { get; set; }

        public ChiTietHoaDonDTO() { }

        public ChiTietHoaDonDTO(int maHoaDon, int maMon, int soLuong, decimal donGia)
        {
            MaHoaDon = maHoaDon;
            MaMon = maMon;
            SoLuong = soLuong;
            DonGia = donGia;
        }
    }
}