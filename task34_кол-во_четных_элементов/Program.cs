/*
Напишите программу, которая подсчитывает количество четных элементов в массиве целых положительных трехзначных чисел 
и выводит результат на экран.
124     378     593     821     456 
Количество четных элементов: 3
*/



int[] GetRnd(int size)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(100, 1000); //рандомные числа
       // array[i] = Convert.ToInt32(Console.ReadLine()); вводит пользователь
    }
    return array;
}

void PrintArray(int[] arr)
{
    System.Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        System.Console.Write(arr[i]);
        if (i < arr.Length - 1)
            System.Console.Write(", ");
    }
    System.Console.Write("]");
}

void CountPos(int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if(arr[i]%2 == 0) count++;
    }
    System.Console.WriteLine(count);
}

int[] array = GetRnd(10);
PrintArray(array);
System.Console.WriteLine();
CountPos(array);

