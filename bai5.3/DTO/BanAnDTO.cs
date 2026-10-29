namespace CafePOS
{
    public class BanAnDTO
    {
        public int MaBan { get; set; }
        public string TenBan { get; set; }
        public string TrangThai { get; set; } // "Trống" hoặc "Có khách"

        public BanAnDTO() { }
        public BanAnDTO(int maBan, string tenBan, string trangThai)
        {
            MaBan = maBan;
            TenBan = tenBan;
            TrangThai = trangThai;
        }
    }
}