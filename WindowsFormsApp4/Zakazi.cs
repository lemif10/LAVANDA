using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp4
{
    class Zakazi
    {
        public int IdZakaza;

        public Klient klient;

        public Sotrudnik sotrudnik;

        public Zakazano[] zakazano;

        public string Oplata;

        public string Dostavka;

        public string Adres_Poluchatelya;

        public string Data_Oformleniya;

        public string Data_Dostavki;

        public float Stoimost_Dostavki;

        public float Summa_Zakaza()
        {
            return 0;
        }

    }
}
