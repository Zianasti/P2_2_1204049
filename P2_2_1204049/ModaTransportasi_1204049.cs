using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P2_2_1204049
{
    class ModaTransportasi_1204049
    {
        static void Main(string[] args)
        {
            Mobil_1204049 transportasi1 = new Mobil_1204049("Mobil", "BMW", "bensin", "Jerman");
            Motor_1204049 transportasi2 = new Motor_1204049("Motor", "Yamaha", "bensin", "136 Km/Jam");
            Sepeda_1204049 transportasi3 = new Sepeda_1204049("Sepeda", "Cannondale", "tidak memakai bahan bakar", "dikayuh");

            Console.WriteLine("Transportasi yang bisa digunakan yaitu : {0}, {1}, dan {2}.", 
                transportasi1.jenis, transportasi2.jenis, transportasi3.jenis);
            Console.WriteLine("{0} dengan Merek {1} menggunakan bahan bakar {2} yang dibuat oleh negara {3}", 
                transportasi1.jenis, transportasi1.merek, transportasi1.BahanBakar, transportasi1.MadeBy);
            Console.WriteLine("{0} dengan Merek {1} menggunakan bahan bakar {2} yang bisa menempuh kecepatan maksimal {3}",
                transportasi2.jenis, transportasi2.merek, transportasi2.BahanBakar, transportasi2.kecepatan);
            Console.WriteLine("{0} dengan Merek {1} {2} karena {3} dijalankan dengan cara {4}",
                transportasi3.jenis, transportasi3.merek, transportasi3.BahanBakar,transportasi3.jenis, transportasi3.cara);
        }
    }
}
