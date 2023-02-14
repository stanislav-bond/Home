// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

//Console.WriteLine("Введите первое число:");
//int a = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("Введите второе число:");
//int b = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine(a > b ? "Первое число больше второго" : "Второе число больше первого");

// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

//Console.WriteLine("Введите первое число:");
//int a = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("Введите второе число:");
//int b = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("Введите третие число:");
//int c = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine(Math.Max(a, Math.Max(b, c)));

// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка)

//Console.WriteLine("Введите число:"); 
//num = Convert.ToInt32(Console.ReadLine());//
//if (num % 2 == 1)
// {
//Console.WriteLine("Число " + num + " является: НЕЧЁТНЫМ");
//}
//else
//{
//Console.WriteLine("Число " + num + "является: ЧЁТНЫМ");
//}

// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

  int i = 1;
            bool not = true;

            Console.WriteLine("Введите число:");
            int num = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Чётные числа от 1 до " + num);
            while (i <= num)
            {
                if (i % 2 != 1)
                {
                    Console.Write(i + ", ");
                    not = false;
                }
                i++;
            }

            if (not)
            {
                Console.WriteLine("Нет чётных чисел!");
            }
