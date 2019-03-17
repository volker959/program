using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Egzamin
{
    class Program
    {
        public class Pojazd
        {
            public string _marka;
            public string _rodzajPaliwa;
            public int _iloscKol;

            public Pojazd(string _marka, string _rodzajPaliwa, int _iloscKol)
            {

                this._marka = _marka;
                this._rodzajPaliwa = _rodzajPaliwa;
                this._iloscKol = _iloscKol;

            }
        }

        public class Laweta
        {
            public string _marka;
            public int _masa;
            public int _nrLawety;
            public UszkodzonySamochod wrak;

            public Laweta()
            {
                _marka = "Renault";
                _masa = 2200;
                _nrLawety = 1;
                wrak = new UszkodzonySamochod("Volvo", "ON", 4, 2000);
            }
            public Laweta(Laweta LawetaKopia)
            {
                _marka = LawetaKopia._marka;
                _masa = LawetaKopia._masa;
                _nrLawety = LawetaKopia._nrLawety;
            }

            public class UszkodzonySamochod : Pojazd
            {
                public int Masa;
                public UszkodzonySamochod(string _marka, string _rodzajPaliwa, int _iloscKol, int _masa) : base(_marka, _rodzajPaliwa, _iloscKol)
                {
                    Masa = _masa;

                }
                public static string _kierownicaPoStronie = "Lewej";
                public static void _FunkcStatyczna()
                {
                    Console.WriteLine("Kierownica po stronie " + _kierownicaPoStronie);
                }

                private int _rokZakupu;
                public int _RokZakupu
                {
                    get { return _rokZakupu; }
                    set { _rokZakupu = value; }
                }
                public int _RokProdukcji { get; set; }
            }
        }


        static void Main(string[] args)
        {
            Laweta MojaLaweta = new Laweta();
            Laweta.UszkodzonySamochod._FunkcStatyczna();

            MojaLaweta.wrak._RokZakupu = 2016;
            MojaLaweta.wrak._RokProdukcji = 2014;

            Laweta KopiaLawety = new Laweta(MojaLaweta);
            Console.ReadKey();

        }
    }
}
