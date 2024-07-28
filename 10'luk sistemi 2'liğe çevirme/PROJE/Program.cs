using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROJE
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayi = 0;
            string binary = "", sistem = "";
            Console.Write("Lütfen 10'luk sayı sistemi girin =");
            sayi = Convert.ToInt32(Console.ReadLine());
            do
            {
                sistem = Convert.ToString(sayi % 2);
                binary = sistem + binary;
                sayi = sayi / 2;
            } while (sayi != 1);
            Console.Write("2'lik sistem karşılığı..: ", sayi);
            Console.WriteLine("1" + binary);
            Console.ReadLine();
        }
    }
}