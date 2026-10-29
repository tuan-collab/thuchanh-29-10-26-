using System.Data;

namespace CafePOS
{
    public class MonAnBUS
    {
        private MonAnDAL monAnDAL = new MonAnDAL();

        public DataTable GetListMonAn() => monAnDAL.GetAllMonAn();
        public DataTable GetListDanhMuc() => monAnDAL.GetDanhMuc();
        public DataTable GetMonByDanhMuc(int maDM) => monAnDAL.GetMonByDanhMuc(maDM);

        public bool AddMonAn(string tenMon, int maDanhMuc, decimal donGia, out string errorMessage)
        {
            errorMessage = string.Empty;

            if (string.IsNullOrWhiteSpace(tenMon))
            {
                errorMessage = "Tên món ăn không được để trống!";
                return false;
            }

            if (donGia < 0)
            {
                errorMessage = "Đơn giá không được âm!";
                return false;
            }

            return monAnDAL.InsertMonAn(tenMon, maDanhMuc, donGia);
        }

        public bool EditMonAn(int maMon, string tenMon, int maDanhMuc, decimal donGia, out string errorMessage)
        {
            errorMessage = string.Empty;

            if (string.IsNullOrWhiteSpace(tenMon))
            {
                errorMessage = "Tên món ăn không được để trống!";
                return false;
            }

            if (donGia < 0)
            {
                errorMessage = "Đơn giá không được âm!";
                return false;
            }

            return monAnDAL.UpdateMonAn(maMon, tenMon, maDanhMuc, donGia);
        }

        public bool RemoveMonAn(int maMon)
        {
            return monAnDAL.DeleteMonAn(maMon);
        }
    }
}