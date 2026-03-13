using System;
using tpmodul4_103082400047;

namespace tpmodul3_NIM
{
    internal class Program
    {
        static void Main(string[] args)  // ← Perbaiki ini!
        {
            // Demo Table-Driven untuk Kode Pos
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

            // ========== TAMBAHKAN KODE DOORMACHINE DI SINI ==========
            Console.WriteLine("=== DEMO STATE-BASED (DOOR MACHINE) ===\n");

            DoorMachine pintu = new DoorMachine(); // State awal: Terkunci

            Console.WriteLine("\nMembuka kunci pintu...");
            pintu.BukaKunci(); // Output: "Pintu tidak terkunci"

            Console.WriteLine("\nMengunci pintu...");
            pintu.KunciPintu(); // Output: "Pintu terkunci"

            Console.WriteLine("\nMembuka kunci lagi...");
            pintu.BukaKunci(); // Output: "Pintu tidak terkunci"

            Console.WriteLine("\nSimulasi selesai.");
            Console.ReadKey();
        }
    }
}