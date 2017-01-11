using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wejsciowka
{
    class Figura : IFigura, IClonable
    {

        public string nazwaFigury;
        public void LiczPole() { }
        public void LiczObwod() { }
        public void PobierzDaneZKlawiatury() { }
        public void Wyswietl() { }
        public Object Clone()
        {
            return MemberwiseClone();
        }
    }
}
