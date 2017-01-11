using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wejsciowka
{
    class Kwadrat : Figura
    {
        public int a, wynik, wynik2;
        public void RPobierzDaneZKlawiatury() { }
        public Kwadrat()
        {

            nazwaFigury = "Kwadrat";
            a = 15;

        }
        public void pokazKwadrat()
        {
           
            Console.WriteLine("Nazwa Figury: {0}, Dlugosc jednego boku wynosi: {1}", nazwaFigury, a);
            

        }

        public void ZLiczPole()
        {
            
            Console.Write("Pole kwadratu wynosi: ");
            
            if (a <= 0)
            {
               
                Console.WriteLine("Bok a nie moze byc liczba ujemna, sprobuj ponownie: ");
                
            }
            else
            {
                wynik = a * a;
                Console.WriteLine("{0}", wynik);
            }
        }
        public void ZLiczObwod()
        {
           
            Console.Write("Obwod kwadratu wynosi: ");
            
            if (a <= 0)
            {
                
                Console.WriteLine("Bok a nie moze byc liczba ujemna, sprobuj ponownie: ");
               
            }
            else
            {
                wynik2 = 4 * a;
                Console.WriteLine("{0}", wynik2);
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
