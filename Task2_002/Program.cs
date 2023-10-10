Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number < 100)
{
    Console.WriteLine("Введенное число не имеет третьей цифры");
    return;
}
else
    while (number > 999)
    {
        number = number / 10;
    }
    int ThreeNumber = number % 10;

    Console.WriteLine($"Третья цифра введенного числа равна {ThreeNumber}");
