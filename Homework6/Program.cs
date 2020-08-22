using System;

namespace ConsoleApp9
{
    class Program
    {
        static void Main(string[] args)
        {

            while (true)
            {
                try
                {

                    Console.WriteLine("Введите имя первого человека");
                    string firstName = Console.ReadLine();
                    Console.WriteLine("Введите возраст первого человека");
                    int firstAge = Convert.ToInt32(Console.ReadLine());
                    if (firstAge <= 0 || firstAge > 97)
                    {
                        Console.WriteLine("Ошибка.Введите настоящий возраст");
                        continue;
                    }

                    Console.WriteLine("Введите имя второго человека");
                    string secondName = Console.ReadLine();

                    Console.WriteLine("Введите возраст второго человека");
                    int secondAge = Convert.ToInt32(Console.ReadLine());
                    if (secondAge <= 0 || secondAge > 97)
                    {
                        Console.WriteLine("Ошибка.Введите настоящий возраст");
                        continue;
                    }

                    Console.WriteLine("Кто старше?");
                    string bigname = Console.ReadLine();


                    if (bigname != firstName && bigname != secondName && bigname != "")
                    {
                        Console.WriteLine("Введите имя старшего из двух людей");
                        continue;
                    }


                    if (firstAge > secondAge)
                    {
                        if (bigname == firstName)
                        {
                            Console.WriteLine($"Правильно! {firstName} старше на {firstAge - secondAge} лет.");
                        }
                        else
                        {
                            Console.WriteLine($"Неправильно! {firstName} старше на {firstAge - secondAge} лет.");
                        }
                    }
                    else if (secondAge > firstAge)
                    {
                        if (bigname == secondName)
                        {
                            Console.WriteLine($"Правильно! {secondName} старше на {secondAge - firstAge} лет.");
                        }
                        else
                        {
                            Console.WriteLine($"Неправильно! {secondName} старше на {secondAge - firstAge} лет.");
                        }
                    }
                    else
                    {
                        if (bigname == firstName || bigname == secondName)
                        {
                            Console.WriteLine($"Неправильно! {firstName} и {secondName} одного возраста.");
                        }
                        else
                        {
                            Console.WriteLine($"{firstName} и {secondName} одного возраста.");
                        }
                    }
                }
                catch
                {
                    Console.WriteLine("Ошибка.Введите настоящий возраст.");
                    continue;
                }
                break;
            }
        }
    }
}