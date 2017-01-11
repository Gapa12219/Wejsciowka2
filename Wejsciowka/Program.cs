using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wejsciowka
{
    class Program
    {
        
        static void Main(string[] args)
        {
             poczatek:
            Console.WriteLine(" ");
            
            Console.WriteLine("Figury , pola i obwod - LEKCJA 5: ");
            
            Console.WriteLine(" ");
           
            Console.WriteLine("[A] - Punkt [Konstruktor domyslny]");
            Console.WriteLine("[B] - Punkt [Dane wprowadzane przez uzytkownika]");
            Console.WriteLine("[C] - Kolo [Konstruktor domyslny]");
            Console.WriteLine("[D] - Kolo [Dane wprowadzane przez uzytkownika]");
            Console.WriteLine("[E] - Kwadrat [Konstruktor domyslny]");
            Console.WriteLine("[F] - Kwadrat [Dane wprowadzane przez uzytkownika]");
            
            
            string litera2 = Console.ReadLine();
            switch (litera2)
            {
                case "a":
                case "A":
                   
                    Console.WriteLine("konstruktor dla Punktu: ");
                   
                    Punkt Punkt = new Punkt();
                    Punkt.Wyswietl();
                    Punkt.pokazPunkt();
                    Console.WriteLine(" ");
                    Console.WriteLine(" ");
 
 
                    goto poczatek;
                   
 
                case "b":
                case "B":
 
                    Console.WriteLine(" ");
                    Punkt Punkt1 = new Punkt();
                    Console.WriteLine("Podaj nazwe punktu: ");
                    Punkt1.nazwaFigury = Console.ReadLine();
                    Console.WriteLine("Podaj wspolrzedna X dla punktu: ");
                    Punkt1.wspX = int.Parse(Console.ReadLine());
                    Console.WriteLine("Podaj wspolrzedna Y dla punktu: ");
                    Punkt1.wspY = int.Parse(Console.ReadLine());
                   
                    Console.WriteLine("       Informacje dla punktu dla podanych przez Ciebie danych: ");
                    Console.WriteLine("Nazwa dla punktu: {0}", Punkt1.nazwaFigury);
                   
                    Punkt1.Wyswietl();
 
                    goto poczatek;
                   
                case "c":
                case "C":
 
                    
                    Console.WriteLine("konstruktor dla kola: ");
                    
                    Kolo kolo = new Kolo();
                    kolo.Wyswietl();
                    kolo.pokazKolo();
                    Console.WriteLine(" ");
                    Console.WriteLine(" ");
                    goto poczatek;
                   
 
                case "d":
                case "D":
 
                    Console.WriteLine(" ");
                    Kolo kolo1 = new Kolo();
                    Console.WriteLine("Podaj nazwe kola: ");
                    kolo1.nazwaFigury = Console.ReadLine();      
                    Console.WriteLine("Podaj wspolrzedna X dla srodka kola: ");
                    kolo1.X = int.Parse(Console.ReadLine());
                    Console.WriteLine("Podaj wspolrzedna Y dla srodka kola: ");
                    kolo1.Y = int.Parse(Console.ReadLine());
                    Console.WriteLine("Podaj promien kola: ");
                    kolo1.r = int.Parse(Console.ReadLine());
                    
                    Console.WriteLine("       Informacje dla kola dla podanych przez Ciebie danych: ");
                    Console.WriteLine("Nazwa dla kola: {0}", kolo1.nazwaFigury);
                    Console.WriteLine("Srodek kola o wspolrzednych: ({0},{1})", kolo1.X, kolo1.Y);
                    
                    kolo1.Wyswietl();
 
                    goto poczatek;
                    
 
                case "e":
                case "E":
 
                    
                    Console.WriteLine("konstruktor dla kwadratu: ");
                    
                    Kwadrat kwadrat = new Kwadrat();
                    kwadrat.Wyswietl();
                    kwadrat.pokazKwadrat();
                    Console.WriteLine(" ");
                    Console.WriteLine(" ");
                    goto poczatek;
                    
 
                case "f":
                case "F":
 
                    Console.WriteLine(" ");
                    Kwadrat kwadrat1 = new Kwadrat();
                    Console.WriteLine("Podaj nazwe kwadratu: ");
                    kwadrat1.nazwaFigury = Console.ReadLine();      
                    Console.WriteLine("Podaj dlugosc boku a: ");
                    kwadrat1.a = int.Parse(Console.ReadLine());                
                    
                    Console.WriteLine("       Informacje dla kwadratu dla podanych przez Ciebie danych: ");
                    Console.WriteLine("Nazwa dla kwadratu: {0}", kwadrat1.nazwaFigury);
                    
                    kwadrat1.Wyswietl();
 
                    goto poczatek;
                    
 
 
              
 
                default:
                    Console.WriteLine("Wybrana przez Ciebie litera nie jest prawidlowa");
                    goto poczatek;
                    
 
            }
           
        }
    }
}
