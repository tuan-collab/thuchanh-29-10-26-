using System.Collections.Generic;
using HotelManagement.DAL;
using HotelManagement.DTO;

namespace HotelManagement.BUS
{
    public class DichVuBUS
    {
        private DichVuDAL dichVuDAL = new DichVuDAL();
        public List<DichVuDTO> GetListDichVu() => dichVuDAL.GetAllDichVu();
    }
}