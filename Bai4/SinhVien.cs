using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai4
{
    public class SinhVien
    {
        public string Ma { get; set; } = "";
        public string HoTen { get; set; } = "";
        public double Diem { get; set; }
        public override string ToString() => $"{Ma,-6} | {HoTen,-16} | {Diem:F1}";
    }
}
