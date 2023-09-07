// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

Console.Write("Введите число: ");
int Num = Convert.ToInt32(Console.ReadLine());
int start = 2;
if (Num <= 1)
{
    Console.WriteLine("Чисел нет.");
}
else while (start <= Num)
{
    Console.WriteLine(start);
    start = start + 2;
}