using System;
using Functions;

namespace Project_1
{
    class Program
    {
        static void Main()
        {
            // Переменные для программы.
            int user_menu_choice;
            string Ress, Name;

            // Бесполезная часть кода.
            Console.WriteLine("Введите ваше имя");
            Name = Console.ReadLine();

            // Псевдо Бесконечный цикл.
            do
            {
                Console.Clear();
                Function.sapka();

                // Функционал меню
                user_menu_choice = int.Parse(Console.ReadLine());
                switch (user_menu_choice)
                {
                    case 0:
                        Console.Clear();
                        Environment.Exit(0);
                        break;

                    case 1:
                        Console.Clear();
                        Function.do_k();
                        break;

                    case 2:
                        Console.Clear();
                        Function.do_kn();
                        break;

                    case 3:
                        Console.Clear();
                        Function.do_degree();
                        break;

                    case 4:
                        Console.Clear();
                        Function.do_comparison();
                        break;

                    case 5:
                        Console.Clear();
                        Function.do_comparisom_2();
                        break;

                    case 6:
                        Console.Clear();
                        Function.do_factorial();
                        break;
                }

                // Точка цикла.
                Console.WriteLine("\nВы хотите продолжить Да/Нет[Y/N]:");
                Ress = Console.ReadLine();
            } while (Ress is "Y" or "y");
        }
    }
}
