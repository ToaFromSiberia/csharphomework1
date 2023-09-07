// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

Console.WriteLine("Введите число №1: ");
string strNum1 = Console.ReadLine();
int Num1 = Convert.ToInt32(strNum1);
Console.WriteLine("Введите число №2: ");
string strNum2 = Console.ReadLine();
int Num2 = Convert.ToInt32(strNum2);
Console.WriteLine("Введите число №3: ");
string strNum3 = Console.ReadLine();
int Num3 = Convert.ToInt32(strNum3);
if (Num1 > Num2 && Num1 > Num3)
{
    Console.WriteLine(Num1);
}
else if (Num2 > Num1 && Num2 > Num3)
{
    Console.WriteLine(Num2);
}
else
{
    Console.WriteLine(Num3);
}