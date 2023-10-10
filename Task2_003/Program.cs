Console.WriteLine("Введите номер дня недели: ");
int day = Convert.ToInt32(Console.ReadLine());
if (day < 1 || day > 7)
{
    Console.WriteLine("Неверный день недели");
    return;
}
else
    if (day == 6 || day == 7)
    {
        Console.WriteLine("Да");
    }
    else
    {
        Console.WriteLine("Нет");
    }
