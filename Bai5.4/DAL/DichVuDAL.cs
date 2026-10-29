using System;
using System.Collections.Generic;
using System.Data;
using HotelManagement.DTO;

namespace HotelManagement.DAL
{
    public class DichVuDAL
    {
        public List<DichVuDTO> GetAllDichVu()
        {
            List<DichVuDTO> list = new List<DichVuDTO>();
            DataTable dt = DatabaseAccess.ExecuteQuery("SELECT * FROM DichVu");
            foreach (DataRow row in dt.Rows)
            {
                list.Add(new DichVuDTO
                {
                    MaDV = Convert.ToInt32(row["MaDV"]),
                    TenDV = row["TenDV"].ToString(),
                    DonGia = Convert.ToDecimal(row["DonGia"])
                });
            }
            return list;
        }
    }
}