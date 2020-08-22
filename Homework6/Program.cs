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
                    string firstName, secondName, bigname;
                    int firstAge, secondAge;

                    FirstPerson(out firstName, out firstAge);
                    SecondPerson(out secondName, out secondAge);
                    BigName(out bigname);

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
                    Console.WriteLine("Ошибка. Введите настоящий возраст.");
                    continue;
                }
                break;
            }

        }

        static void FirstPerson(out string firstName, out int firstAge)
        {
            while (true)
            {
                Console.WriteLine("Введите имя первого человека");
                firstName = Console.ReadLine();


                Console.WriteLine("Введите возраст первого человека");
                firstAge = Convert.ToInt32(Console.ReadLine());
                if (firstAge <= 0 || firstAge > 97)
                {
                    Console.WriteLine("Ошибка. Введите настоящий возраст.");
                    continue;
                }
                break;
            }

        }

        static void SecondPerson(out string secondName, out int secondAge)
        {
            while (true)
            {
                Console.WriteLine("Введите имя второго человека");
                secondName = Console.ReadLine();

                Console.WriteLine("Введите возраст второго человека");
                secondAge = Convert.ToInt32(Console.ReadLine());
                if (secondAge <= 0 || secondAge > 97)
                {
                    Console.WriteLine("Ошибка. Введите настоящий возраст.");
                    continue;
                }
                break;
            }

        }

        static void BigName(out string bigname)
        {
            while (true)
            {
                Console.WriteLine("Кто из двоих старше? Если одного возраста пропустите вопрос. ");
                bigname = Console.ReadLine();
                break;
            }
        }

    }

}
