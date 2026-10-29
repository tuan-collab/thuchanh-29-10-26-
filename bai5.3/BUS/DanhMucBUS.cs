using System.Collections.Generic;

namespace CafePOS
{
    public class DanhMucBUS
    {
        private DanhMucDAL danhMucDAL = new DanhMucDAL();

        public List<DanhMucDTO> GetListDanhMuc() => danhMucDAL.GetListDanhMuc();
    }
}