using System.Collections.Generic;

namespace CafePOS
{
    public class BanAnBUS
    {
        private BanAnDAL banAnDAL = new BanAnDAL();

        public List<BanAnDTO> GetListBanAn() => banAnDAL.GetListBanAn();
    }
}