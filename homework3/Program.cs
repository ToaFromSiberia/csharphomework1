// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

Console.WriteLine("Enter a number: ");
int num = Convert.ToInt32(Console.ReadLine());
int remain = num % 2;
if (remain > 0)
{
    Console.WriteLine("Число нечётное");
}
else
{
    Console.WriteLine("Число чётное");
}