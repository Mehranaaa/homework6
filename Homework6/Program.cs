using System;

namespace ConsoleApp2
{

    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                try
                {
                    string name1, name2, bigname;
                    int age1, age2;

                    Names(out name1, out name2);
                    Ages(out age1, out age2);

                    Console.WriteLine("Кто из двоих старше? ");
                    bigname = Console.ReadLine();

                    if (age1 > age2)
                    {
                        if (bigname == name1)
                        {
                            Console.WriteLine($"Правильно! {name1} старше на {age1 - age2} лет.");
                        }
                        else
                        {
                            Console.WriteLine($"Неправильно! {name1} старше на {age1 - age2} лет.");
                        }
                    }

                    else if (age2 > age1)
                    {
                        if (bigname == name2)
                        {
                            Console.WriteLine($"Правильно! {name2} старше на {age2 - age1} лет.");
                        }
                        else
                        {
                            Console.WriteLine($"Неправильно! {name2} старше на {age2 - age1} лет.");
                        }
                    }

                    else
                    {
                        Console.WriteLine($"{name1} и {name2} одного возраста.");
                    }
                }
                catch
                {
                    continue;
                }
                break;
            }

        }


        static void Names(out string name1, out string name2)
        {

            Console.WriteLine("Введите имя первого человека");
            name1 = Console.ReadLine();

            Console.WriteLine("Введите имя второго человека");
            name2 = Console.ReadLine();
        }

        static void Ages(out int age1, out int age2)
        {
            while (true)
            {
                try
                {
                    Console.WriteLine("Введите возраст первого человека");
                    age1 = Convert.ToInt32(Console.ReadLine());
                    if (age1 <= 0 || age1 > 97)
                    {
                        continue;
                    }
                    Console.WriteLine("Введите возраст второго человека");
                    age2 = Convert.ToInt32(Console.ReadLine());
                    if (age2 <= 0 || age2 > 97)
                    {
                        continue;
                    }
                }
                catch
                {
                    continue;
                }
                break;
            }
        }

    }
}


