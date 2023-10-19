/*
Напишите программу, которая принимает на вход число (N) 
и выдаёт таблицу кубов чисел от 1 до N.

N = 3 
1
8
27

N = 5
1
8
27
64
125
*/


System.Console.WriteLine("Введите число: ");
int n = Convert.ToInt32(System.Console.ReadLine());

for (int i = 1; i <= n; i++)
    //System.Console.Write(Math.Pow(i, 3) + " ");
    System.Console.WriteLine($"{i} * {i} * {i} = {Math.Pow(i, 3)}");
   