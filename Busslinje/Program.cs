using System;

namespace Busslinje
{
    class Program
    {
        
        static void Main(string[] args)
        {

            Hållplats[] Hållplatser = new Hållplats[10];     // array Hållaplats

            int numInhpl, numUthpl;   //  fermate di salita e discesa

            // stampa delle fermate
            Console.Clear();

            for (int i = 0; i <10; i++)
            {
                Console.SetCursorPosition(5 + i, 1);
                Console.Write($"Hpl{i}  väntande passagerare {Hållplatser[i].påstigningPass}");
            }

            Random r = new Random();

            numInhpl = r.Next(1,10);      // numInhpl = numero casuale delle fermate di salita  ( da 1 a 9 )
            numUthpl = r.Next(numInhpl + 1, 11);      // successiva alla prima fermata fino all´ultima cioé num 10.

            Passagerare passagerare = new Passagerare(numInhpl,numUthpl);

            
            Console.WriteLine("");
        }
    }
}
