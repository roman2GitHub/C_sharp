Console.WriteLine("Введите трехзначное число");
int Number = Convert.ToInt32(Console.ReadLine());
if (Number < 99 || Number > 999)
{
    Console.WriteLine("Введено не трехзначное число");
}
else
{
    int secondNumber = (Number / 10) % 10;
    Console.WriteLine($"Вторая цифра трехзначного числа равна: {secondNumber}");
}
