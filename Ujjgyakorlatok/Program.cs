using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ujjgyakorlatok
{
    internal class Program
    {
        static void Main(string[] args) 
        { 
            // PROGRAM ÁLTAL HASZNÁLT NÉHÁNY VÁLTOZÓ INICIALIZÁLÁSA
            int[] szamok = new int[30];
            int lKSzam = 0;
            int lNSzam = 0;
            Random rnd = new Random();

            // LISTA FELTÖLTÉSE
            for (int i = 0; i < 30; i++)
            {
                szamok[i] = rnd.Next(21, 30);
            }

            // LISTA KIÍRÁSA
            foreach (int item in szamok)
            {
                Console.Write($"{item} ");
            }

            // LEGKISEBB ÉS LEGNAGYOBB SZÁMOKAT TARTALMAZÓ VÁLTOZÓBA HELYEZZÜK A FÜGGVÉNYEK ÁLTAL ADOTT SZÁMOKAT
            lKSzam = MinKereses(szamok);
            lNSzam = MaxKereses(szamok);

            // EREDMÉNYEK KIÍRÁSA
            Console.WriteLine($"\n\nA legkisebb szám: {lKSzam}");
            Console.WriteLine($"A legnagyobb szám: {lNSzam}");
        }

        /// <summary>
        /// A megadott listából megkeresi a legnagyobb számot 
        /// </summary>
        /// <param name="szamLista"></param>
        /// <returns></returns>
        static int MinKereses(int[] szamLista)
        {
            
            
            int min = szamLista[0];

            foreach (int szam in szamLista)
            {
                if (szam < min)
                {
                    min = szam;
                }
            }

            return min;
        }

        /// <summary>
        /// A megadott listából megkeresi a legkisebb számot 
        /// </summary>
        /// <param name="szamLista"></param>
        /// <returns></returns>
        static int MaxKereses(int[] szamLista)
        {            
            int max = szamLista[0];

            foreach (int szam in szamLista)
            {
                if (szam > max)
                {
                    max = szam;
                }
            }

            return max;
        }

    }   
}
