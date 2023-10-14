/*
Напишите программу, которая принимает на вход координаты двух точек и 
находит расстояние между ними в 2D пространстве.

A (3,6); B (2,1) -> 5,09
A (7,-5); В (1,-1) -> 7,21
*/

System.Console.WriteLine("Введите первое число: ");
int x1 = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите второе число: ");
int y1 = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите третье число: ");
int x2 = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите четвертое число: ");
int y2 = Convert.ToInt32(Console.ReadLine());

//  Math - библиотека
// Pow - возводит в квадрат, после запятой указываем в какую степень
// Sqrt - корень из числа
// Math.Round - метод округления, первый аргумент (все наше большое число)
// в конце после запятой до какого числа нужно округлить (до двух)

double d = Math.Round(Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2)), 2);
System.Console.WriteLine(d);
