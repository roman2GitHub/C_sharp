Console.WriteLine("Введите число больше единицы: ");
int number = Convert.ToInt32(Console.ReadLine());
for (int i = 2; i < number; i = i + 2)
{
    Console.Write(i + " ");
}
// for (int i = 2; i < number; i+=2)
// {
//     Console.Write(i);
// }

