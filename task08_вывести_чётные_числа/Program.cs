﻿/*
Внутри класса Answer напишите метод PrintEvenNumbers, которая на вход принимает число (number), 
а на выходе выводит все чётные числа от 1 до number (включительно), разделеные знаком табуляции.
*/

System.Console.WriteLine("Введите число: ");

int number = Convert.ToInt32(System.Console.ReadLine());

for (int i = 2; i < number; i = i + 2) // в цикле for всегда 3 показателя: точка входа, условие выхода из цикла, шаг
{
    System.Console.Write(i + "\t");
}
