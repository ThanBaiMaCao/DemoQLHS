using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoQLHS
{
    //sua cho nay
    internal class HocSinh
    {
        private float diemToan;
        private float diemVan;
        private DateTime ngaySinh;
        private string diaChi;
        private string hoTen;
        private string maSo;
        private string gioiTinh;

        public HocSinh()
        {
            this.diemToan = 0.0f;
            this.diemVan = 0.0f;
            this.ngaySinh = DateTime.Now;
            this.diaChi = "";
            this.hoTen = "";
            this.maSo = "";
            this.gioiTinh = "";
        }
        public HocSinh (float diemToan, float diemVan, DateTime ngaySinh, string diaChi, string hoTen, string maSo,string gioiTinh)
        {
            this.diemToan = diemToan;
            this.diemVan = diemVan;
            this.ngaySinh = ngaySinh;
            this.diaChi = diaChi;
            this.hoTen = hoTen;
            this.maSo = maSo;
            this.gioiTinh = gioiTinh;
        }
        public string GioiTinh
        {
            get { return this.gioiTinh; }
            set { this.gioiTinh = value; }
        }
        public float DiemToan
        {
            get { return this.diemToan; }
            set { this.diemToan = value; }
        }
        public float DiemVan
        {
            get { return this.diemVan; }
            set { this.diemVan = value; }
        }
        public DateTime NgaySinh
        {
            get { return this.ngaySinh; }
            set { this.ngaySinh = value; }
        }
        public string DiaChi
        {
            get { return this.diaChi; }
            set { this.diaChi = value; }
        }
        public string HoTen
        {
            get { return this.hoTen; }
            set { this.hoTen = value; }
        }
        public string MaSo
        {
            get { return this.maSo; }
            set { this.maSo = value; }
        }
    }
}
