using System;
using System.IO;
using System.Text.Json;

namespace TjModul7_Kelompok7
{
    public class Address
    {
        public string streetAddress { get; set; }
        public string city { get; set; }
        public string state { get; set; }
    }

    public class Course
    {
        public string code { get; set; }
        public string name { get; set; }
    }

    public class DataMahasiswa2311104049
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string gender { get; set; }
        public int age { get; set; }
        public Address address { get; set; }
        public Course[] courses { get; set; }

        public void ReadJSON()
        {
            string fileName = "jurnal7_1_2311104049.json";

            if (!File.Exists(fileName))
            {
                Console.WriteLine("File tidak ditemukan: " + fileName);
                return;
            }

            string jsonString = File.ReadAllText(fileName);

            var mahasiswa = JsonSerializer.Deserialize<DataMahasiswa2311104049>(jsonString);

            if (mahasiswa == null)
            {
                Console.WriteLine("Gagal melakukan deserialisasi JSON.");
                return;
            }

            Console.WriteLine($"Nama: {mahasiswa.firstName} {mahasiswa.lastName}");
            Console.WriteLine($"Gender: {mahasiswa.gender}");
            Console.WriteLine($"Age: {mahasiswa.age}");

            if (mahasiswa.address != null)
            {
                Console.WriteLine($"Address: {mahasiswa.address.streetAddress}, {mahasiswa.address.city}, {mahasiswa.address.state}");
            }

            if (mahasiswa.courses != null)
            {
                Console.WriteLine("Courses:");
                foreach (var course in mahasiswa.courses)
                {
                    Console.WriteLine($"- {course.code}: {course.name}");
                }
            }
        }
    }
}
