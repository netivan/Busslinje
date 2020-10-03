using System;
using System.Security.Cryptography.X509Certificates;
using System.Timers;
using System.Threading;

namespace Busslinje
{
    class Program
    {
        
        static void Main(string[] args)
        {

            Hållplats hPlats = new Hållplats();

            int numInhpl, numUthpl;   //  fermate di salita e discesa

            // stampa delle fermate


            hPlats.skriva();

            int tid = 0;
            Random r = new Random();
            int hpl = 1;
            do {
                numInhpl = r.Next(1, 9);      // numInhpl = numero casuale delle fermate di salita  ( da 1 a 9 )
                numUthpl = r.Next(numInhpl + 1, 10);      // successiva alla prima fermata fino all´ultima cioé num 10.

                Passagerare passagerare = new Passagerare(numInhpl, numUthpl);

                Hållplats.psgIn[numInhpl]++;
                Hållplats.psgUt[numUthpl]++;

                Hållplats.skriva1(numInhpl);
                if ( tid % 9 == 0)
                { Buss.moveBuss(hpl);
                    hpl++;
                    Console.ReadKey();

                    if (hpl == 10) hpl = 1;
                }
                tid++;
                Console.SetCursorPosition(80, 2);
                Console.Write(tid);
                Thread.Sleep(400);
            } while (tid < 200);
              

            Console.ReadKey();
            
        }
    }
}
