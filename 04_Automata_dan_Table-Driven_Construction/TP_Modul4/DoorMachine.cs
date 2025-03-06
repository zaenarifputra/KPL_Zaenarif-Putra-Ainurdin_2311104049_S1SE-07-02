using System;

namespace Automata_dan_Table_Driven_Construction
{
    public class DoorMachine
    {
        public enum State { Terkunci, Terbuka }

        private State currentState;

        public DoorMachine()
        {
            currentState = State.Terkunci;
            Console.WriteLine("Pintu terkunci");
        }

        public void BukaPintu()
        {
            if (currentState == State.Terkunci)
            {
                currentState = State.Terbuka;
                Console.WriteLine("Pintu tidak terkunci");
            }
            else
            {
                Console.WriteLine("Pintu sudah terbuka");
            }
        }

        public void KunciPintu()
        {
            if (currentState == State.Terbuka)
            {
                currentState = State.Terkunci;
                Console.WriteLine("Pintu terkunci");
            }
            else
            {
                Console.WriteLine("Pintu sudah terkunci");
            }
        }

        // ✅ Mengubah StatusPintu agar mengembalikan string
        public string StatusPintu()
        {
            return currentState == State.Terkunci ? "Pintu terkunci" : "Pintu tidak terkunci";
        }
    }
}