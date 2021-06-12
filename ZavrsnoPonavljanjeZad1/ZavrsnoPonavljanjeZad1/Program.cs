using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZavrsnoPonavljanjeZad1
{
    class Program
    {
        static void Main(string[] args)
        {
            string znakovi, sVelika, sMala, sPrvaTri, sZadnjihPet, s8_11;
            Console.Write("Upisite znakove: ");
            znakovi = Console.ReadLine();
            sVelika = znakovi.ToUpper();
            sMala = znakovi.ToLower();
            sPrvaTri = znakovi.Substring(0, 3);
            sZadnjihPet = znakovi.Substring(znakovi.Length - 5);
            try { s8_11 = znakovi.Substring(8, 3); }
            catch (Exception e) { s8_11 = "Unesli ste malo znakova"; }
            Console.WriteLine("sVelika = " + sVelika + "\nsMala = " + sMala + "\nsPrvaTri = " + sPrvaTri + "\nsZadnjihPet = " + sZadnjihPet + "\ns8_11 = " + s8_11);
            Console.ReadKey();
        }
    }
}
