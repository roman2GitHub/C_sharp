﻿Console.WriteLine("Введите первое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int number2 = Convert.ToInt32(Console.ReadLine());
if (number1 > number2)
{
    Console.WriteLine(number1 + " большее " + number2 + " меньшее");
}
else
{
    Console.WriteLine(number1 + " меньшее, " + number2 + " большее");
}