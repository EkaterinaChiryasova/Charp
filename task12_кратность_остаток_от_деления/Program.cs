﻿/*
Напишите программу, которая будет на вход принимать два числа и
выводить, является ли второе число кратным первому. Если второе число некратно
первому, то программа выводит остаток от деления
34, 5 -> некратно, остаток 4
16, 4 -> кратно
*/

System.Console.WriteLine("Введите первое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите второе число: ");
int number2 = Convert.ToInt32(Console.ReadLine());

if (number1 % number2 == 0)
{
    System.Console.WriteLine("Кратно ");
}
else
System.Console.WriteLine("Некратно, " + "остаток " + number1 % number2);