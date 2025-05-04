using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatematikaLibraries
{
    public class MatematikaApps
    {
        public static int FPB(int a, int b)
        { 
            while (b !=0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }
            return a;
        }
        public static int KPK(int a, int b)
        {
            return (a * b) / FPB(a, b);
        }
        public static string Turunan(int[] koef)
        {
            List<string> hasil = new List<string>();
            for (int i = 0; i < koef.Length; i++)
            {
                int pangkat = koef.Length - i - 1;
                int koefTurunan = koef[i] * pangkat;
                if (koefTurunan != 0)
                    hasil.Add($"{(koefTurunan >= 0 && i > 0 ? "+ " : "")}{koefTurunan}x{(pangkat - 1 == 0 ? "" : $"^{pangkat - 1}")}");
            }
            return string.Join(" ", hasil);
        }
        public static string Integral(int[] koef)
        {
            List<string> hasil = new List<string>();
            for (int i = 0; i < koef.Length; i++)
            {
                int pangkatBaru = koef.Length - i;
                double koefIntegral = (double)koef[i] / pangkatBaru;
                hasil.Add($"{(koefIntegral >= 0 && i > 0 ? "+ " : "")}{koefIntegral}x{(pangkatBaru == 1 ? "" : $"^{pangkatBaru}")}");
            }
            hasil.Add("+ C");
            return string.Join(" ", hasil);
        }
    }
}
