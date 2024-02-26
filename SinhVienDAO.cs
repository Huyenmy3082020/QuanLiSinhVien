using QuanLiCafe.Dao;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace QuanLiSinhVienWinForm
{
    public class SinhVienDAO
    {
        private static SinhVienDAO instance;

        public static SinhVienDAO Instance 
        {
            get
            {
                if (instance == null)
                {
                    instance = new SinhVienDAO();
                }
                return instance;
            }
            
            set => instance = value; }
        public List<SinhVien> LayDanhSachSinhVien()
        {
            List<SinhVien> list_SinhVien = new List<SinhVien>();
            string query = "select *from tblSinhVien";

            DataTable data = DataProvider.Instance.excuteQuery(query);
;            foreach (DataRow row in data.Rows)
            {
                SinhVien sv = new SinhVien(row);
                list_SinhVien.Add(sv);
            }
            return list_SinhVien;

        }
        
        public bool ThemSinhVien(string masv, string hoten,string ngaySinh, string diachi, string sdt,string gioiTinh)
        {
            string query
            = string.Format("insert tblSinhVien (maSV,hoTen,ngaySinh,diaChi,sdt,gioiTinh) values ({0},{1},{2},{3},{4},{5})", masv,hoten,ngaySinh,diachi,sdt,gioiTinh);

            DataTable result = DataProvider.Instance.excuteQuery(query);
            return result.Rows.Count > 0;
        }
        public List<SinhVien> LayraIDCuaSinhVien(string id)
        {
        List<SinhVien> list = new List<SinhVien>();
            DataTable data = DataProvider.Instance.excuteQuery("select *from tblSinhien where maSV=" + id);
            foreach (DataRow row in data.Rows)
            {
                SinhVien sv = new SinhVien(row);
                list.Add(sv);
            }
            return list;
       }
    }
}

