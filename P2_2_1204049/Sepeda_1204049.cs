using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P2_2_1204049
{
    public class Sepeda_1204049:Transportasi_1204049
    {
        protected string Cara;
        public Sepeda_1204049(string jenis, string merek, string BahanBakar, string cara): base(jenis, merek, BahanBakar)
        {
   
            this.Cara = cara;
            
        }
        public string cara
        {
            get
            {
                return Cara;

            }
            set
            {
                Cara = value;
            }
        }
    }
}
