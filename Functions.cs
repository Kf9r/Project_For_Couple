using System;

namespace Functions
{
    class Function { 
        // Матиматические функции.
        public static int math_k(int pk, int px) { return pk * px; }
        public static int math_kn(int pk, int pn, int px) { return (pk - pn) * px; }
        public static int math_degree(int pk, int px, int pc) { return (int)((pk * Math.Pow(px, 3.0)) + pc); }

        // Вывод в консоль меню.
        public static void sapka()
        {
        Console.WriteLine("==================================================#");
        Console.WriteLine("Введите: (1) Для уравнения у=k*x                  #");
        Console.WriteLine("Введите: (2) Для уравнения y=(k-n)*x              #");
        Console.WriteLine("Введите: (3) Для уравнения y=k*x^3+c              #");
        Console.WriteLine("Введите: (4) Сравнение чисел на max/min           #");
        Console.WriteLine("Введите: (5) Сравнение (A+B)^2?(A-B)^2            #");
        Console.WriteLine("Введите: (6) Для вычисление P!                    #");
        Console.WriteLine("Введите: (0) Для выход                            #");
        Console.WriteLine("===================================================");
        }

        public static void do_k()
        {
        int k, x;
        Console.WriteLine("Введите k для уравнения у=k*x.");
        k = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите x для уравнения у=k*x.");
        x = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine($"Ответ: {math_k(k, x)}");
        }

        public static void do_kn()
        {
        int k, n, x;
        Console.WriteLine("Введите k для уравнения y=(k-n)*x.");
        k = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите n для уравнения y=(k-n)*x.");
        n = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите x для уравнения y=(k-n)*x.");
        x = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine($"Ответ: {math_kn(k, n, x)}");
        }

        public static void do_degree()
        {
        int k, x, c;
        Console.WriteLine("Введите k для уравнения y=k*x^3+c.");
        k = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите x для уравнения y=k*x^3+c.");
        x = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите c для уравнения y=k*x^3+c.");
        c = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine($"Ответ: {math_degree(k, x, c)}");
        }

        public static void do_comparison()
        {
        int a, b;
        Console.WriteLine("ПРЕДУПРЕЖДЕНИЕ: ЧИСЛА НЕ ДОЛЖНЫ БЫТЬ ОДИНАКОВЫ.");
        Console.WriteLine("ВВедите A");
        a = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("ВВедите B");
        b = Convert.ToInt32(Console.ReadLine());
        if (a > b) Console.WriteLine("A больше B");
        else Console.WriteLine("B больше A");
        }

        public static void do_comparisom_2()
        {
        int a, b;
        Console.WriteLine("ПРЕДУПРЕЖДЕНИЕ: ЧИСЛА НЕ ДОЛЖНЫ БЫТЬ ОДИНАКОВЫ.");
        Console.WriteLine("ВВедите A");
        a = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("ВВедите B");
        b = Convert.ToInt32(Console.ReadLine());

        if (Math.Pow(a + b, 2.0) > Math.Pow(a - b, 2.0)) Console.WriteLine("(A+B)^2 больше (A-B)^2");
        else Console.WriteLine("(A+B)^2 Меньше (A-B)^2");
        }

        public static void do_factorial()
        {
            int p, y;
            Console.WriteLine("Введите P");
            p = Convert.ToInt32(Console.ReadLine());

            y = 1;
            for (int i = 1; i <= p; i++) y *= i;
            Console.WriteLine($"Факториал P! = {y}");
        }

    }

}
