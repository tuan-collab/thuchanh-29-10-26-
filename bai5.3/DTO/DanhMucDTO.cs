namespace CafePOS
{
    public class DanhMucDTO
    {
        public int MaDanhMuc { get; set; }
        public string TenDanhMuc { get; set; }

        public DanhMucDTO() { }
        public DanhMucDTO(int maDanhMuc, string tenDanhMuc)
        {
            MaDanhMuc = maDanhMuc;
            TenDanhMuc = tenDanhMuc;
        }
    }
}