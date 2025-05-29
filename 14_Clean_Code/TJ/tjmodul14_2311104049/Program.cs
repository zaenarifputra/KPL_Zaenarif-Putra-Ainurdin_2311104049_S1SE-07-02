using System;
using System.Collections.Generic;

namespace cleancodemd5
{
    /// <summary>
    /// Generic class digunakan sebagai tempat menyimpan data beserta cap waktu input.
    /// </summary>
    public class SimpleDatabase<T>
    {
        private readonly List<T> _storedData;
        private readonly List<DateTime> _inputDates;

        public SimpleDatabase()
        {
            _storedData = new List<T>();
            _inputDates = new List<DateTime>();
        }

        /// <summary>
        /// Menambahkan data baru dengan stempel waktu UTC saat ini.
        /// </summary>
        public void AddNewData(T data)
        {
            _storedData.Add(data);
            _inputDates.Add(DateTime.UtcNow);
        }

        /// <summary>
        /// Mencetak semua data yang tersimpan beserta stempel waktunya.
        /// </summary>
        public void PrintAllData()
        {
            for (int i = 0; i < _storedData.Count; i++)
            {
                Console.WriteLine($"Data {i + 1} berisi: {_storedData[i]}, yang disimpan pada waktu UTC: {_inputDates[i]}");
            }
        }
    }

    /// <summary>
    /// Class digunakan untuk melakukan generic mathematical operations.
    /// </summary>
    public class MathOperations
    {
        /// <summary>
        /// Metode umum yang digunakan untuk menjumlahkan tiga nilai menggunakan pengetikan dinamis.
        /// </summary>
        public void AddThreeNumbers<T>(T value1, T value2, T value3)
        {
            dynamic a = value1;
            dynamic b = value2;
            dynamic c = value3;
            dynamic result = a + b + c;

            Console.WriteLine($"Hasil penjumlahan: {result}");
        }
    }

    /// <summary>
    /// CLass utama yang digunakan untuk menjalankan program.
    /// </summary>
    public static class Program
    {
        public static void Main()
        {
            var database = new SimpleDatabase<int>();

            Console.WriteLine("== Program SimpleDatabase ==\n");
            Console.WriteLine("Masukkan tiga angka dua digit dari NIM:");

            // Input 3 values from user
            for (int i = 0; i < 3; i++)
            {
                Console.Write($"Masukkan angka ke-{i + 1}: ");
                int inputNumber;
                while (!int.TryParse(Console.ReadLine(), out inputNumber) || inputNumber < 10 || inputNumber > 99)
                {
                    Console.Write("Input tidak valid! Masukkan angka dua digit (10-99): ");
                }

                database.AddNewData(inputNumber);
            }

            Console.WriteLine("\nData yang telah dimasukkan:");
            database.PrintAllData();

            Console.WriteLine("\n== Program Penjumlahan ==\n");
            Console.Write("Masukkan NIM Anda: ");
            string nim = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(nim) || nim.Length < 8)
            {
                Console.WriteLine("NIM harus memiliki minimal 8 digit.");
                return;
            }

            // Extract 2-digit segments from NIM
            string segment1 = nim.Substring(0, 2);
            string segment2 = nim.Substring(2, 2);
            string segment3 = nim.Substring(4, 2);
            char lastDigit = nim[nim.Length - 1];

            var calculator = new MathOperations();

            try
            {
                switch (lastDigit)
                {
                    case '1':
                    case '2':
                        float f1 = float.Parse(segment1);
                        float f2 = float.Parse(segment2);
                        float f3 = float.Parse(segment3);
                        calculator.AddThreeNumbers(f1, f2, f3);
                        break;

                    case '3':
                    case '4':
                    case '5':
                        double d1 = double.Parse(segment1);
                        double d2 = double.Parse(segment2);
                        double d3 = double.Parse(segment3);
                        calculator.AddThreeNumbers(d1, d2, d3);
                        break;

                    case '6':
                    case '7':
                    case '8':
                        int i1 = int.Parse(segment1);
                        int i2 = int.Parse(segment2);
                        int i3 = int.Parse(segment3);
                        calculator.AddThreeNumbers(i1, i2, i3);
                        break;

                    case '9':
                    case '0':
                        long l1 = long.Parse(segment1);
                        long l2 = long.Parse(segment2);
                        long l3 = long.Parse(segment3);
                        calculator.AddThreeNumbers(l1, l2, l3);
                        break;

                    default:
                        Console.WriteLine("Digit terakhir NIM tidak valid.");
                        break;
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Format input tidak valid.");
            }

            Console.WriteLine("\nTekan Enter untuk keluar...");
            Console.ReadLine();
        }
    }
}