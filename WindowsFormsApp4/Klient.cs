using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp4
{
    class Klient : Person
    {
        public int работаетИлиНет;

        public string DataRozdeniya;

        public string Adres;

        public int Skidka;

        public bool InfoKlient()
        {
            Console.WriteLine("Введите фамилию:");

            Familiya = Console.ReadLine();

            Console.WriteLine("Введите имя:");

            Imya = Console.ReadLine();

            Console.WriteLine("Введите отчество:");

            Otchestvo = Console.ReadLine();

            Console.WriteLine("Введите телефон:");

            Telefon = Console.ReadLine();

            Console.WriteLine("Введите Email:");

            Email = Console.ReadLine();

            Console.WriteLine("Введите дату рождения:");

            DataRozdeniya = Console.ReadLine();

            Console.WriteLine("Введите дату  адрес:");

            Adres = Console.ReadLine();

            Console.WriteLine("Введите скидку:");
           
            Skidka = int.Parse(Console.ReadLine());

            return true;
        }
         
        public bool KlientPrint()
        {
            Console.WriteLine(Familiya + " " + Imya + " " + Otchestvo + " " + Telefon + " " + Email + " " + DataRozdeniya + " " +Adres+" "+ Skidka);

            return true;
        }
    }
   

}
