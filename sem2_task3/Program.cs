﻿// является ли первое число кратно второму числу, если нет, то вывести
// остаток от деления.
// 16  8 => да
// 15  7 => нет, 1


Console.WriteLine("ввод первого числа");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("ввод второго числа");
int num2 = Convert.ToInt32(Console.ReadLine());

int result = num1 % num2;

if (result == 0)
{
    Console.WriteLine("да, второе число является кратным первого");
}
else
{
    Console.WriteLine("нет, второе число не является кратным первого, остаток  = "  + result);
}
