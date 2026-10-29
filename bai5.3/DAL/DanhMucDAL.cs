using System;
using System.Collections.Generic;
using System.Data;

namespace CafePOS
{
    public class DanhMucDAL
    {
        public List<DanhMucDTO> GetListDanhMuc()
        {
            List<DanhMucDTO> list = new List<DanhMucDTO>();
            DataTable dt = DatabaseAccess.ExecuteQuery("SELECT * FROM DanhMuc");
            foreach (DataRow row in dt.Rows)
            {
                list.Add(new DanhMucDTO
                {
                    MaDanhMuc = Convert.ToInt32(row["MaDanhMuc"]),
                    TenDanhMuc = row["TenDanhMuc"].ToString()
                });
            }
            return list;
        }
    }
}