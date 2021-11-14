using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P2_2_1204049
{
    public class Motor_1204049: Transportasi_1204049
    {
        protected string Kecepatan;

        public Motor_1204049(string jenis,string merek,string bahanBakar,string kecepatan): base(jenis,merek,bahanBakar)
        {
            this.Kecepatan = kecepatan;
        }

        public string kecepatan
        {
            get
            {
                return Kecepatan;
            }
            set
            {
                kecepatan = value;
            }
        }
    }
}
