using System;

public class Answer
{
    static void CompareNumbers(int firstNumber, int secondNumber)
    {
        // Введите свое решение ниже
        if (firstNumber > secondNumber)
        {
            Console.WriteLine("Первое число '" + firstNumber + "' больше чем второе число " + secondNumber);
        }
        else if (firstNumber < secondNumber)
        {
            Console.WriteLine("Первое число `" + firstNumber + "` меньшее чем второе число `" + secondNumber + "`");
        }
        else
        {
            Console.WriteLine("Введенные числа равны " + firstNumber);
        }

    }


    // Не удаляйте и не меняйте метод Main! 
    static public void Main(string[] args)
    {
        int firstNumber, secondNumber;

        if (args.Length >= 2)
        {
            firstNumber = int.Parse(args[0]);
            secondNumber = int.Parse(args[1]);
        }
        else
        {
            // Здесь вы можете поменять значения для отправки кода на Выполнение
            firstNumber = 7;
            secondNumber = 8;
        }

        // Не удаляйте строки ниже
        CompareNumbers(firstNumber, secondNumber);
    }
}


// Console.WriteLine("Введите первое число: ");
// int number1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите второе число: ");
// int number2 = Convert.ToInt32(Console.ReadLine());
// if (number1 > number2)
// {
//     Console.WriteLine(number1 + " большее " + number2 + " меньшее");
// }
// else if(number1 < number2)
// {
//     Console.WriteLine(number1 + " меньшее, " + number2 + " большее");
// }
// else
// {
//     Console.WriteLine("Числа равны");
// }