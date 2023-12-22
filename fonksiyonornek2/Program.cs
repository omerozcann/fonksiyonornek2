using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fonksiyonornek2
{
    internal class Program
    {
        static int kontrol(String a,String b)
        {
            if(a==b)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }
        static String kontrol2(String a, String b)
        {
            if (a == b)
            {
                return "eşit";
            }
            else
            {
                return "eşit değil";
            }
        }
        static void Main(string[] args)
        {
            /*
             Örnek: Kendisine gönderilen 2 string eşit ise 1, değil ise 0 değerini
            döndüren bir fonksiyon yazınız.
             */
            /*
             Örnek: Kendisine gönderilen 2 string eşit ise "eşit", değil ise "eşit değil"
            stringini  döndüren bir fonksiyon yazınız.
             */
            String x, y,z;
            int s;
            Console.WriteLine("1. kelimeyi gir:");
            x= Console.ReadLine();
            Console.WriteLine("2. kelimeyi gir:");
            y = Console.ReadLine();
            s=kontrol(x,y);
            z = kontrol2(x, y);
            Console.WriteLine("Sonuç={0}", s);
            Console.WriteLine("Sonuç={0}", z);
        }
    }
}
