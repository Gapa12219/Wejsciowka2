using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wejsciowka
{
    class Kolo : Figura
    {
        public int r, X, Y, R;
        public double wynik, obwod;
        public void ZPobierzDaneZKlawiatury() { }
        public Kolo()
        {

            nazwaFigury = "Kolo";
            X = 12;
            Y = 8;
            r = 25;

        }
        public void pokazKolo()
        {
           
            Console.WriteLine("Nazwa Figury: {0}, Srodek kola o wspolrzednych: ({1},{2}), promien kola: {3}", nazwaFigury, X, Y, r);
            

        }
        public void ZLiczPole()
        {
          
            Console.Write("Pole kola wynosi (przy przyjeciu za pi=3,14): ");
            
            if (r <= 0)
            {
               
                Console.WriteLine("Promien nie moze byc liczba ujemna, sprobuj ponownie: ");
                
            }
            else
            {
                R = r * r;
                wynik = 3.14 * R;
                Console.WriteLine("{0}", wynik);
            }

        }
        public void ZLiczObwod()
        {

            
            Console.Write("Obwod kola wynosi (przy przyjeciu za pi=3,14): ");
            
            if (r <= 0)
            {
                
                Console.WriteLine("Promien nie moze byc liczba ujemna, sprobuj ponownie: ");
                
            }
            else
            {
                obwod = 2 * 3.14 * r;
                Console.WriteLine("{0}", obwod);
            }

        }

        public void ZWyswietl()
        {
            LiczObwod();
            LiczPole();
           
            Console.WriteLine("IClonable:");
            Clone();
            
            Console.WriteLine(" ");

        }
        public Object ZClone()
        {
            return MemberwiseClone();
        }
    }
}
