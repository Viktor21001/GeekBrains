﻿/*Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

//a = 5; b = 7 -> max = 7
//a = 2 b = 10 -> max = 10
//a = -9 b = -3 -> max = -3


Console.WriteLine("Введите числа");

int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());


if (a > b)
{
    Console.Write(" Число a больше чем b");
}
if (b > a)
{
    Console.Write(" Число b больше чем a");
}
if (a == b)
{
    Console.Write("Числа равны");
}
*/

//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
/*Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

//2, 3, 7 -> 7
//44 5 78 -> 78
//22 3 9 -> 22

int firstNumber, secondNumber, thirdNumber;
int max = 0;

firstNumber = Convert.ToInt32(Console.ReadLine());
secondNumber = Convert.ToInt32(Console.ReadLine());
thirdNumber = Convert.ToInt32(Console.ReadLine());

if (firstNumber > secondNumber) 
    {
        max = firstNumber;

    }
if (secondNumber > max) 
    {
        max = secondNumber;
    }
if (thirdNumber > max) 
    {
        max = thirdNumber;
    }
        Console.Write("max = ");
        Console.WriteLine(max);
*/

////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
/*Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

//4 -> да
//-3 -> нет
//7 -> нет

int evenNumber;
Console.WriteLine("Введите четное число ");
evenNumber = Console.Read();

if (evenNumber % 2 == 1)
{
    Console.WriteLine("Это не четное число!!!");
}
if (evenNumber % 2 == 0)
{
    Console.Write("является целым числом!!!");
}
*/

///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
/*Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

//5 -> 2, 4
//8 -> 2, 4, 6, 8

int n = Convert.ToInt32(Console.ReadLine());
int m = Convert.ToInt32(Console.ReadLine());

for (int i = 1; i <= m; i++)
{
    if (i % 2 == 0)
    {
        Console.WriteLine(i);
    }
}
*/