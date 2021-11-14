using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P2_2_1204049
{
    public class Transportasi_1204049
    {
        private string bJenis;
        private string bMerek;
        private string bBahanBakar;

        public Transportasi_1204049(string jenis, string merek, string bahanBakar)
        {
            this.bJenis = jenis;
            this.bMerek = merek;
            this.bBahanBakar = bahanBakar;
        }
        public string jenis
        {
            get
            {
                return bJenis;
            }
            set
            {
                bJenis = value;
            }
        }
        public string merek
        {
            get
            {
                return bMerek;
            }
            set
            {
                bMerek = value;
            }
        }
        public string BahanBakar
        {
            get
            {
                return bBahanBakar;
            }
            set
            {
                bBahanBakar = value;
            }
        }
    }
}
