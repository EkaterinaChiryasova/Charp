﻿/*
0. Напишите программу, которая на вход принимает число
и выдает его квадрат (число умноженное на себя)
*/
Console.WriteLine("Введите число: "); // cw - быстрый вызов Console.WriteLine
int userNumber = Convert.ToInt32(Console.ReadLine());

int result = userNumber * userNumber;

System.Console.WriteLine(result);
System.Console.WriteLine(userNumber * userNumber);