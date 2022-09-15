using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonHoc
{
    internal class Diem
    {
        private double diemMh;
        private double stc;
        public Diem() { }
        public Diem(double diemMh, double stc)
        {
            this.diemMh = diemMh;
            this.stc = stc;
        }

        public double DiemMh { get => diemMh; set => diemMh = value; }
        public double Stc { get => stc; set => stc = value; }
    }
}
