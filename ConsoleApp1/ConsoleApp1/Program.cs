using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string password = "0451";
            int trys;
            string tryPassword;
            Console.WriteLine("Введите пароль");

            for (trys = 3; trys > 0; trys--)
            {
                Console.WriteLine($"У вас осталось {trys} попыток");
                tryPassword = Console.ReadLine();

                if (tryPassword == password)
                {
                    Console.WriteLine("Секретное сообщение");
                    break;
                }
            }
        }
    }
}