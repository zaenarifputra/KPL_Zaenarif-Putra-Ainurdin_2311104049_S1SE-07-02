using System;

namespace tjmodul4_2311104049
{
    public interface IState
    {
        void TombolW(Karakter karakter);
        void TombolS(Karakter karakter);
    }

    public class Berdiri : IState
    {
        public void TombolW(Karakter karakter)
        {
            Console.WriteLine("Tombol arah atas ditekan"); // NIM % 3 == 0
            karakter.SetState(new Terbang());
            Console.WriteLine("Karakter mulai terbang.");

            if (karakter.NIM % 3 == 2)
            {
                Console.WriteLine("Posisi take off");
            }
        }

        public void TombolS(Karakter karakter)
        {
            Console.WriteLine("Tombol arah bawah ditekan"); // NIM % 3 == 0
            karakter.SetState(new Jongkok());
            Console.WriteLine("Karakter mulai jongkok.");
        }
    }

    public class Jongkok : IState
    {
        public void TombolW(Karakter karakter)
        {
            Console.WriteLine("Tombol arah atas ditekan"); // NIM % 3 == 0
            karakter.SetState(new Berdiri());
            Console.WriteLine("Karakter kembali berdiri.");

            if (karakter.NIM % 3 == 1)
            {
                Console.WriteLine("Posisi standby");
            }
        }

        public void TombolS(Karakter karakter)
        {
            Console.WriteLine("Tombol arah bawah ditekan"); // NIM % 3 == 0
            karakter.SetState(new Tengkurap());
            Console.WriteLine("Karakter tengkurap.");

            if (karakter.NIM % 3 == 1)
            {
                Console.WriteLine("Posisi istirahat");
            }
        }
    }

    public class Tengkurap : IState
    {
        public void TombolW(Karakter karakter)
        {
            Console.WriteLine("Tombol arah atas ditekan"); // NIM % 3 == 0
            karakter.SetState(new Jongkok());
            Console.WriteLine("Karakter kembali jongkok.");
        }

        public void TombolS(Karakter karakter)
        {
            Console.WriteLine("Tidak bisa turun lagi, sudah posisi terendah.");
        }
    }

    public class Terbang : IState
    {
        public void TombolW(Karakter karakter)
        {
            Console.WriteLine("Tidak bisa naik lebih tinggi.");
        }

        public void TombolS(Karakter karakter)
        {
            Console.WriteLine("Tombol arah bawah ditekan"); // NIM % 3 == 0
            karakter.SetState(new Berdiri());
            Console.WriteLine("Karakter kembali berdiri.");

            if (karakter.NIM % 3 == 2)
            {
                Console.WriteLine("Posisi landing");
            }
        }
    }

    public class Karakter
    {
        private IState _state;
        public long NIM { get; private set; }

        public Karakter(long nim)
        {
            NIM = nim;
            _state = new Berdiri(); // Default state
            Console.WriteLine("Karakter mulai dari posisi berdiri.");

            if (NIM % 3 == 1)
            {
                Console.WriteLine("Posisi standby");
            }
        }

        public void SetState(IState state)
        {
            _state = state;
        }

        public void TekanTombolW()
        {
            _state.TombolW(this);
        }

        public void TekanTombolS()
        {
            _state.TombolS(this);
        }
    }
}
