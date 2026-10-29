using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace CafePOS
{
    public class BanAnDAL
    {
        public List<BanAnDTO> GetListBanAn()
        {
            List<BanAnDTO> list = new List<BanAnDTO>();
            DataTable dt = DatabaseAccess.ExecuteQuery("SELECT * FROM BanAn");
            foreach (DataRow row in dt.Rows)
            {
                list.Add(new BanAnDTO
                {
                    MaBan = Convert.ToInt32(row["MaBan"]),
                    TenBan = row["TenBan"].ToString(),
                    TrangThai = row["TrangThai"].ToString()
                });
            }
            return list;
        }
    }
}