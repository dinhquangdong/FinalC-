﻿using System.Data;
namespace Final.DAO
{
    public class TruongDAO
    {
        private static TruongDAO instance;

        public static TruongDAO Instance
        {
            get { if (instance == null) instance = new TruongDAO(); return TruongDAO.instance; }
            private set { TruongDAO.instance = value; }
        }
        private TruongDAO() { }


        public DataTable GetListTruong()
        {
            return DataProvider.Instance.ExcuteQuery("Select TenTruong,AnhTruong from TRUONG");
        }

        public DataTable TimKiem(string text)
        {
            DataTable dt = new DataTable();
            dt = DataProvider.Instance.ExcuteQuery($"Select TenTruong, AnhTruong from TRUONG where dbo.fuConvertToUnsign1(TenTruong) like N'%'+dbo.fuConvertToUnsign1('{text}')+'%'");
            return dt;
        }

        public bool deleteTruongFromMaOrTen(string matruong, string tentruong)
        {
            CTNganhHocDAO.Instance.deleteCTNganhFromMaTruongAndMaNghanh(matruong, "");

            if (matruong=="" && tentruong == "")
            {
                return false;
            }
            string query = "Delete TRUONG where " + (matruong != "" ? " MaTruong = N'" + matruong + "'" : " ") + ((matruong == "" && tentruong != "") ||(matruong != "" && tentruong == "") ?" ":" or ")
                    + (tentruong != "" ? " TenTruong = N'" + tentruong + "'" : "");
            int result = DataProvider.Instance.ExcuteNonQuery(query);
            return result>0;
        }


    }
}
