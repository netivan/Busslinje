using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Busslinje
{
    class Buss
    {
        public int maxNumPasg = 90;
        public double hastighet = 15; // hastighet i km/h
        public string linjeNamn = "2 sofia";
        public int bussNummer = 4238;

          Hållplats hPlats = new Hållplats();

        public static void moveBuss(int hpl) 
        {
            Console.SetCursorPosition(45, hpl + 4);
            Console.Write($"bussen stannar vid {hpl} , avstigande psg {Hållplats.psgUt[hpl]} , påstigande  psg {Hållplats.psgIn[hpl]} ");
            Hållplats.psgIn[hpl] = 0;
           Hållplats.psgUt[hpl] = 0;
            Console.ReadKey();
            Hållplats.skriva1(hpl);
        }
    }
}
