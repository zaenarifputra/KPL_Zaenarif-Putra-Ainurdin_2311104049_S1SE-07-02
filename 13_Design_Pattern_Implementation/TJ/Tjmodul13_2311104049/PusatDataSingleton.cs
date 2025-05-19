using System;
using System.Collections.Generic;

namespace implementasi_singleton
{
    public class PusatDataSingleton
    {
        private static PusatDataSingleton _instance = null;
        public List<string> DataTersimpan;

        private PusatDataSingleton()
        {
            DataTersimpan = new List<string>();
        }

        public static PusatDataSingleton GetDataSingleton()
        {
            if (_instance == null)
            {
                _instance = new PusatDataSingleton();
            }
            return _instance;
        }

        public List<string> GetSemuaData()
        {
            return DataTersimpan;
        }

        public void PrintSemuaData()
        {
            if (DataTersimpan.Count == 0)
            {
                Console.WriteLine("(Tidak Terdapat Data Yang Disimpan)");
            }
            else
            {
                for (int i = 0; i < DataTersimpan.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. {DataTersimpan[i]}");
                }
            }
        }

        public void AddSebuahData(string input)
        {
            DataTersimpan.Add(input);
        }

        public void HapusSebuahData(int index)
        {
            if (index >= 0 && index < DataTersimpan.Count)
            {
                DataTersimpan.RemoveAt(index);
            }
            else
            {
                Console.WriteLine("Index invalid. Tidak ada data yang dihapus.");
            }
        }

        public override string ToString()
        {
            return $"PusatDataSingleton dengan {DataTersimpan.Count} data tersimpan.";
        }
    }
}
