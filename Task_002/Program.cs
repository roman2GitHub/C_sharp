﻿// // Максимальное из трех чисел
// Console.WriteLine("Введите первое число:");
// int number1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите второе число:");
// int number2 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите третье число:");
// int number3 = Convert.ToInt32(Console.ReadLine());
// int max = number1;
// if (number2 > max)
// {
//     max = number2;
// }
// if (number3 > max)
// {
//     max = number3;
// }
// Console.WriteLine(max);

using System;

public class Answer
{

    static int FindMax(int a, int b, int c)
    {
        // Введите свое решение ниже
        int max = a;
        if (b > max) max = b;
        if (c > max) max = c;
        return max;

    }

    // Не удаляйте и не меняйте метод Main! 
    static public void Main(string[] args)
    {
        int a, b, c;

        if (args.Length >= 3)
        {
            a = int.Parse(args[0]);
            b = int.Parse(args[1]);
            c = int.Parse(args[2]);
        }
        else
        {
            // Здесь вы можете поменять значения для отправки кода на Выполнение
            a = 9;
            b = 6;
            c = 1;
        }

        // Не удаляйте строки ниже
        int result = FindMax(a, b, c);
        System.Console.WriteLine($"{result}");
    }
}