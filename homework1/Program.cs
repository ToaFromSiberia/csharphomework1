// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

Console.WriteLine("Введите число №1: ");
string strNum1 = Console.ReadLine();
int Num1 = Convert.ToInt32(strNum1);
Console.WriteLine("Введите число №2: ");
string strNum2 = Console.ReadLine();
int Num2 = Convert.ToInt32(strNum2);
if (Num1 > Num2)
{
    Console.WriteLine(Num1);
    Console.WriteLine(" больше, ");
    Console.WriteLine(Num2);
    Console.WriteLine(" меньше.");
}
else if (Num2 > Num1)
{
    Console.WriteLine(Num2);
    Console.WriteLine(" больше, ");
    Console.WriteLine(Num1);
    Console.WriteLine(" меньше.");
}
else
{
    Console.WriteLine("Числа равны");
}