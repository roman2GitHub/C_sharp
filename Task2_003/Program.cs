Console.WriteLine("Введите номер дня недели: ");
int day = Convert.ToInt32(Console.ReadLine());
while (day < 1 || day > 7)
{
    Console.WriteLine("Неверный день недели");
    return;
}
if (day == 6 || day == 7)
{
    Console.WriteLine("Да");
}
else
{
    Console.WriteLine("Нет");
}
