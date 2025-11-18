using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoQLHS
{
    public partial class Form1 : Form
    {
        private DanhMucHocSinh dmHS = new DanhMucHocSinh();
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            float diemToan = float.Parse(txtDiemToan.Text); 
            float diemVan = float.Parse(txtDiemVan.Text);
            DateTime ngaySinh = dtpNgaySinh.Value;
            string diaChi = txtDiaChi.Text;
            string hoTen = txtHoTen.Text;
            string maSo = txtMaSo.Text;
            string gioiTinh = null;
            if(radNam.Checked == true)
            {
                gioiTinh = "Nam";
            }
            else
            {
                gioiTinh = "Nữ";
            }
            HocSinh hs = new HocSinh(diemToan,diemVan,ngaySinh,diaChi,hoTen,maSo,gioiTinh);
            bool ketQua = dmHS.themHocSinh(hs);
            if (ketQua == true)
            {
                MessageBox.Show ("Đã thêm một học sinh","Thành công",MessageBoxButtons.OK, MessageBoxIcon.Information);
               
            }
            else
            {
                MessageBox.Show("Học sinh này đã có trong danh sách rồi");
               
            }
            HienThi(dgvDanhMucHocSinh, dmHS.DSHocSinh);

        }
        private void HienThi (DataGridView dgv , List<HocSinh> hocSinh)
        {
            dgv.DataSource= hocSinh.ToList();
        }
        private void radNam_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
