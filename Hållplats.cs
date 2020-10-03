using System;
using System.Collections.Generic;
using System.Text;

namespace Busslinje
{
    class Hållplats
    {
        public int hållplats = 0;
        public static int[] psgUt = new int[10];       // scendono
        public static int[] psgIn = new int[10];                          // in attesa 
        public string hållplatsNamn = "   ";

        public static void skriva1(int i)
        { 
            Console.SetCursorPosition( 1 , i + 5 );
            Console.WriteLine($"hpl  {i + 1} : {psgIn[i]}    väntande passagerare   ");
        }
        public void skriva()
        {
            Console.Clear();

            for (int i = 0; i < 10; i++)

                 skriva1(i);                //Console.WriteLine($"hpl{i+1} : {psgIn[i]} väntande passagerare   ");
            
        }
    }
}
