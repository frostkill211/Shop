using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Products GreenApple = new Products(
                "Зелёные Яблоки.",
                "Очень вкусные зеленые яблочки. Ням ням!",
                8.36,
                150
                );
            Products RedApple = new Products(
                "Красные Яблоки.",
                "Очень вкусные красные яблочки. Ням ням!",
                9.36,
                150
                );
            Products Cucumbers = new Products(
                "Огурчик",
                "Огурчик РИИИИИК!",
                4.50,
                256
                );
            Products Pepper = new Products(
                "Перец",
                "Хот чилли пеппер",
                5.32,
                132
                );

            Products Chicken = new Products(
                "Курочка",
                "Свежайшая куриная тушка.",
                43.99,
                4
                );
            Products FriedChicken = new Products(
                "Жареная Курочка",
                "Прожареная куриная тушка. Сочное и нежное мясо.",
                63.99,
                4
                );




            Console.WriteLine("МАГАЗИН ЧЕТВЕРОЧКА");
            Console.WriteLine("\nКаталог товаров");
            Console.WriteLine($"1. Фрукты и овощи\n" +
                $"2. Мясо\n" +
                $"3. Чай и кофе\n" +
                $"4. Молочные изделия\n"
                );
            Console.WriteLine("Выберите какой вид товара вам нужен");
            Console.WriteLine(new String('-', 25));
            int katalog = Int32.Parse(Console.ReadLine());
            Console.Clear();
            switch (katalog)
            {
                case 1:

                    Console.WriteLine("Фрукты и овощи.");
                    Console.WriteLine(
                          $"\n1.{GreenApple.ProductName} {GreenApple.Price}р"
                        + $"\n2.{RedApple.ProductName} {RedApple.Price}р"
                        + $"\n3.{Cucumbers.ProductName} {Cucumbers.Price}р"
                        + $"\n4.{Pepper.ProductName} {Pepper.Price}р"
                        );
                    Console.WriteLine("Выберите продукт, который хотите купить");
                    Console.WriteLine(new String('-', 25));
                    int fruktiandovoshi = Int32.Parse(Console.ReadLine());
                    Console.Clear();
                    switch (fruktiandovoshi)
                    {
                        case 1:
                            Console.WriteLine("Фрукты и овощи");
                            Console.WriteLine();
                            break;
                        default:
                            break;
                    }
                    break;
                case 2:
                    break;
                case 3:
                    break;
                case 4:
                    break;
                default:
                    Console.WriteLine("Вы ввели не верный порядковый номер.");
                    break;
            }



        }
    }
}