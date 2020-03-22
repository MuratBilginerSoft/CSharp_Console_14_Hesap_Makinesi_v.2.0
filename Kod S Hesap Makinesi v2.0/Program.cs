using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Kod_S_Hesap_Makinesi_v2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.White;
            Console.Clear();
            double a, b, s = 0;
            string t;
            for (int i = 0; i <= 100; i++)
            {
                Console.WriteLine("Birinci sayıyı giriniz=");
                a = double.Parse(Console.ReadLine());
                Console.WriteLine("İkinci sayıyı giriniz=");
                b = double.Parse(Console.ReadLine());
                Console.WriteLine("Operatörünüzü giriniz");
                t = Console.ReadLine();
                Console.Clear();
                switch (t)
                {
                    case "+":

                        s = a + b;
                        Console.WriteLine("Sonuç=" + s);

                        break;
                    case "-":

                        if (a > b)
                            s = a - b;
                        else if (b > a)
                            s = b - a;
                        else
                            s = a - b;
                        Console.WriteLine("Sonuç=" + s);
                        break;

                    case "*":

                        s = a * b;
                        Console.WriteLine("Sonuç=" + s);
                        break;

                    case "/":

                        if (a / b == 0)

                            s = a / b;

                        Console.WriteLine("Sonuç=" + s);

                        if (a / b != 0)
                            Console.WriteLine("İfadeler tam bölünmüyor!!!");

                        break;

                    default:

                        Console.WriteLine("Yanlış bir operatör girdiniz tekrar deneyiniz");
                        break;
                }
            }
        }
    }
}
