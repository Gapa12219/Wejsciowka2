using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wejsciowka
{
    class Punkt : Figura
    {

        public int wspX, wspY, wynik;
        public void TPobierzDaneZKlawiatury() { }
        public void ZLiczPole()
        {
            
            Console.WriteLine("Nie mozna policzyc pola punktu");
            
        }
        public Punkt()
        {

            nazwaFigury = "nazwa punktu";
            wspX = 20;
            wspY = 5;

        }
        public void pokazPunkt()
        {
            
            Console.WriteLine("Nazwa Figury: {0}, wspX: {1}, wspY: {2}", nazwaFigury, wspX, wspY);
            

        }
        public void ZLiczObwod()
        {
           
            Console.WriteLine("Obwod punktu wynosi 0");
            
        }
        public void dlugoscMetodaPunkt()
        {


            if (wspX > wspY)
            {
                wynik = wspX - wspY;
                Console.WriteLine("Dlugosc punktu wynosi: {0} ", wynik);
            }
            else
            {
                wynik = wspY - wspX;
                Console.WriteLine("Dlugosc punktu wynosi: {0} ", wynik);
            }
        }

        public void ZWyswietl()
        {
           
            Console.WriteLine("IClonable:");
            Clone();
            
            Console.WriteLine(" ");
            dlugoscMetodaPunkt();
            LiczObwod();
            LiczPole();

        }

        public Object ZClone()
        {
            return MemberwiseClone();
        }
    }
}
