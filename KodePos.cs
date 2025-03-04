using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tpmodul3_2311104049
{
    class KodePos
    {
        string[,] dataKodePos =
        {
            {"Batununggal", "40266"},
            {"Kujangsari", "40287"},
            {"Mengger", "40267"},
            {"Wates", "Wates"},
            {"Cijaura", "40287" },
            {"Jatisari", "40286"},
            {"Margasari", "40286"},
            {"Sekejati", "40286"},
            {"Kebonwaru", "40272"},
            {"Maleer", "40274"},
            {"Samoja", "40273" },
        };

        public void MenampilkanSemuaKodePos()
        {
            for (int i = 0; i < dataKodePos.GetLength(0); i++)
            {
                Console.WriteLine($"Kode Pos Kelurahan {dataKodePos[i, 0]}: {dataKodePos[i, 1]}");
            }
        }

        public string GetKodePos(string kelurahan)
        {
            for (int i = 0; i < dataKodePos.GetLength(0); i++)
            {
                if (dataKodePos[i, 0].ToLower() == kelurahan.ToLower())
                {
                    return dataKodePos[i, 1];
                }
            }
            return "Data Kode Pos Tidak Ditemukan!!";
        }
    }
}
