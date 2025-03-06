namespace Automata_dan_Table_Driven_Construction
{
    class Program
{
    static void Main(string[] args)
    {
            KodePos kodePos = new KodePos(); // Membuat objek kode pos
            Console.WriteLine("Menampilkan Data Kode Pos : "); // Menampilkan data kode pos
            kodePos.MenampilkanSemuaKodePos(); // Menampilkan semua kode pos
            Console.WriteLine("");


            Console.WriteLine("Menampilkan System Pintu :");
            DoorMachine pintu = new DoorMachine();
            Console.WriteLine();

            pintu.BukaPintu();
            Console.WriteLine($"Mengecek Pintu: {pintu.StatusPintu()}");
            Console.WriteLine();

            pintu.KunciPintu();
            Console.WriteLine($"Mengecek Pintu: {pintu.StatusPintu()}");
            Console.WriteLine();

            pintu.KunciPintu();  // Coba kunci lagi
            pintu.BukaPintu();   // Coba buka lagi

            Console.ReadLine();
        }
    }
}