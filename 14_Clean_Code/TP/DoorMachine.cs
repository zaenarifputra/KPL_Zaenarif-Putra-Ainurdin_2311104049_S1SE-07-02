using System;

namespace Doormachine
{
    /// <summary>
    /// Kelas simulasi mesin pintu sederhana menggunakan konsep state machine.
    /// </summary>
    public class DoorMachine
    {
        // State yang mungkin dimiliki pintu
        private enum DoorState
        {
            Terkunci,
            Terbuka
        }

        // Menyimpan status terkini pintu
        private DoorState _currentState;

        /// <summary>
        /// Konstruktor: Secara default, pintu dalam keadaan terkunci.
        /// </summary>
        public DoorMachine()
        {
            _currentState = DoorState.Terkunci;
            Console.WriteLine("Pintu terkunci");
        }

        /// <summary>
        /// Membuka pintu jika dalam keadaan terkunci.
        /// </summary>
        public void BukaPintu()
        {
            if (_currentState == DoorState.Terkunci)
            {
                _currentState = DoorState.Terbuka;
                Console.WriteLine("Pintu tidak terkunci");
            }
            else
            {
                Console.WriteLine("Pintu sudah terbuka");
            }
        }

        /// <summary>
        /// Mengunci pintu jika dalam keadaan terbuka.
        /// </summary>
        public void KunciPintu()
        {
            if (_currentState == DoorState.Terbuka)
            {
                _currentState = DoorState.Terkunci;
                Console.WriteLine("Pintu terkunci");
            }
            else
            {
                Console.WriteLine("Pintu sudah terkunci");
            }
        }

        /// <summary>
        /// Mengembalikan status pintu saat ini dalam bentuk string.
        /// </summary>
        /// <returns>Status pintu (terkunci atau tidak)</returns>
        public string StatusPintu()
        {
            return _currentState == DoorState.Terkunci
                ? "Pintu terkunci"
                : "Pintu tidak terkunci";
        }
    }
}