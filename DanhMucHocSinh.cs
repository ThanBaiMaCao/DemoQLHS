using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoQLHS
{
    internal class DanhMucHocSinh
    {
        private List<HocSinh> dsHocSinh;
        public DanhMucHocSinh () 
        { 
            this.dsHocSinh = new List<HocSinh> ();
        }
        public List<HocSinh> DSHocSinh
        {
            get { return this.dsHocSinh; }
            set { this.dsHocSinh = value; }
        }
        public bool themHocSinh (HocSinh hs)
        {
            if (kiemTraMa(hs.MaSo) == true)
            {
                return false;
            }
            else
            {
                this.dsHocSinh.Add(hs);
                return true;
            }
        }
        public bool kiemTraMa(string ma) 
        {
            foreach (HocSinh hs in this.dsHocSinh) 
            {
                if (hs.MaSo.Equals(ma))
                {
                    return true;
                }
            }return false;
        }

    }
}
