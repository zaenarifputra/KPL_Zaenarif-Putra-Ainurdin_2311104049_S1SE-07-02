using System;

namespace Kodepos
{
    /// <summary>
    /// Kelas untuk menyimpan dan mengelola data kode pos berdasarkan nama kelurahan.
    /// </summary>
    public class KodePos
    {
        // Array dua dimensi untuk menyimpan data kelurahan dan kode pos
        private readonly string[,] _dataKodePos =
        {
            { "Batununggal", "40266" },
            { "Kujangsari", "40287" },
            { "Mengger", "40267" },
            { "Wates", "Wates" },
            { "Cijaura", "40287" },
            { "Jatisari", "40286" },
            { "Margasari", "40286" },
            { "Sekejati", "40286" },
            { "Kebonwaru", "40272" },
            { "Maleer", "40274" },
            { "Samoja", "40273" }
        };

        /// <summary>
        /// Menampilkan semua data kelurahan beserta kode pos-nya ke konsol.
        /// </summary>
        public void TampilkanSemuaKodePos()
        {
            for (int i = 0; i < _dataKodePos.GetLength(0); i++)
            {
                Console.WriteLine($"Kode Pos Kelurahan {_dataKodePos[i, 0]}: {_dataKodePos[i, 1]}");
            }
        }

        /// <summary>
        /// Mengembalikan kode pos berdasarkan nama kelurahan (case-insensitive).
        /// </summary>
        /// <param name="kelurahan">Nama kelurahan</param>
        /// <returns>Kode pos atau pesan error jika tidak ditemukan</returns>
        public string GetKodePos(string kelurahan)
        {
            for (int i = 0; i < _dataKodePos.GetLength(0); i++)
            {
                if (_dataKodePos[i, 0].Equals(kelurahan, StringComparison.OrdinalIgnoreCase))
                {
                    return _dataKodePos[i, 1];
                }
            }

            return "Data yang dicari tidak ditemukan!";
        }
    }
}
