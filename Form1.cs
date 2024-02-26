using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLiSinhVienWinForm
{
    public partial class Form1 : Form
    {

        string loai;

 
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridViewDanhSachSinhVien.DataSource = SinhVienDAO.Instance.LayDanhSachSinhVien();
        }
        void LoadList()
        {
            dataGridViewDanhSachSinhVien.DataSource = SinhVienDAO.Instance.LayDanhSachSinhVien();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void dataGridViewDanhSachSinhVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        /*  private void btnThemMoi_Click(object sender, EventArgs e)
          {
              if (SinhVienDAO.Instance.ThemSinhVien(txbMaSinhVien.Text, txbHoTenSinhVien.Text,txbNgaySinh.Text, txbDiaChi.Text,txtSoDienThoai.Text,txbGioiTinh.Text))
              {
                  MessageBox.Show("Them moi thanh cong");
                  LoadList();
              }
          }*/


    }
}
