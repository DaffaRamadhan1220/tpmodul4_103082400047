using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tpmodul4_103082400047
{
    public class KodePos
    {
        private Dictionary<string, int> tabelKodePos = new Dictionary<string, int>()
    {
        {"Batununggal", 40266},
        {"Kujangsari", 40287},
        {"Mengger", 40267},
        {"Wates", 40256},
        {"Cijaura", 40287},
        {"Jatisari", 40286},
        {"Margasari", 40286},
        {"Sekejati", 40286},
        {"Kebonwaru", 40272},
        {"Maleer", 40274},
        {"Samoja", 40273}
    };

        public int? getKodePos(string kelurahan)
        {
            if (tabelKodePos.ContainsKey(kelurahan))
            {
                return tabelKodePos[kelurahan];
            }
            else
            {
                Console.WriteLine("Kelurahan tidak ditemukan.");
                return null;
            }
        }
    
