using System;
using tpmodul4_103082400047;

namespace tpmodul3_NIM
{
    internal class Program
    {
        static void Main(string[] args)  
        {
            
            Console.WriteLine("=== DEMO TABLE-DRIVEN (KODE POS) ===\n");

            KodePos kodePos = new KodePos();

            string[] sampleKelurahan = { "Batununggal", "Cijaura", "Maleer", "Margasari", "Sekejati" };

            foreach (string kel in sampleKelurahan)
            {
                int? kode = kodePos.GetKodePos(kel);
                if (kode.HasValue)
                {
                    Console.WriteLine($"Kode pos untuk {kel} adalah {kode}");
                }
            }

            Console.WriteLine("\nTekan sembarang tombol untuk lanjut ke demo state-based...");
            Console.ReadKey();
            Console.Clear();

            
            Console.WriteLine("=== DEMO STATE-BASED (DOOR MACHINE) ===\n");

            DoorMachine pintu = new DoorMachine(); 

            Console.WriteLine("\nMembuka kunci pintu...");
            pintu.BukaKunci(); 

            Console.WriteLine("\nMengunci pintu...");
            pintu.KunciPintu(); 

            Console.WriteLine("\nMembuka kunci lagi...");
            pintu.BukaKunci(); 

            Console.WriteLine("\nSimulasi selesai.");
            Console.ReadKey();
        }
    }
}
