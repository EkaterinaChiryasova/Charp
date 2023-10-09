/*
Внутри класса Answer напишите метод PrintEvenNumbers, которая на вход принимает число (number), а на выходе выводит все чётные числа 
от 1 до number (включительно), разделеные знаком табуляции.
*/

System.Console.WriteLine("Введите число: ");

int number = Convert.ToInt32(System.Console.ReadLine());

if (number % 2 == 0)
{
    System.Console.WriteLine("Число чётное: ");
}
else
System.Console.WriteLine("Число нечётное: ");