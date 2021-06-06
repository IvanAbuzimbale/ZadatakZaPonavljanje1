using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZadatakZaPonavljanje1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Upišite neki niz znakova: ");
            string znakovi = Console.ReadLine();

            string sVelika = znakovi.ToUpper();
            string sMala = znakovi.ToLower();
            string sPrvaTri = znakovi.Substring(0, 3);
            string sZadnjihPet = znakovi.Substring(znakovi.Length - 5);
            string s8_11 = znakovi.Substring(7, 4);
            Console.WriteLine(sVelika);
            Console.WriteLine(sMala);
            Console.WriteLine(sPrvaTri);
            Console.WriteLine(sZadnjihPet);
            Console.WriteLine(s8_11);
            Console.ReadKey();
        }
    }
}
