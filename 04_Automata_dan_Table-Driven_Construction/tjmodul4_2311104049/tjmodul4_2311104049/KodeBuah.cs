using System;
using System.Collections.Generic;


namespace tjmodul4_2311104049
{
    class KodeBuah
    {
        private static Dictionary<string, string> KodeBuahDict = new Dictionary<string, string>
        {
           {"Apel", "A00"}, {"Aprikot", "B00"}, {"Alpukat", "C00"},
            {"Pisang", "D00"}, {"Paprika", "E00"}, {"Kurma", "K00"},
            {"Durian", "L00"}, {"Anggur", "M00"}, {"Melon", "N00"},
            {"Semangka", "O00"}
        };
        public static string getKodeBuah(string buah)
        {
            return KodeBuahDict.ContainsKey(buah) ? KodeBuahDict[buah]
                : "Kode buah tidak ditemukan";
        }
    }
}
