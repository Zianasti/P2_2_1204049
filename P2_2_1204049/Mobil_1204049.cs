using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P2_2_1204049
{
    public class Mobil_1204049: Transportasi_1204049
    {
        protected string Madeby;
        public Mobil_1204049(string jenis, string merek, string bahanBakar,string madeby) : base(jenis, merek, bahanBakar)
        {
            this.Madeby = madeby;
        }

        public string MadeBy
        {
            get
            {
                return Madeby;
            }
            set
            {
                Madeby = value;
            }
        }

        
    }
}
