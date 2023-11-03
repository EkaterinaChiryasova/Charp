/*
Задайте двумерный массив размером m×n, 
заполненный случайными целыми числами.
*/ 

// Обозначение индекса
/*
void Print2DArray(int[,] array)
{
System.Console.Write($"[ ]\t");
int start = 0;
for (int i = start; i < start + array.GetLength(1); i++)
{
System.Console.Write($"[{i}]\t");
}
System.Console.WriteLine();
for (int i = 0; i < array.GetLength(0); i++)
{
System.Console.Write($"["+ i +"]\t");
for (int j = 0; j < array.GetLength(1); j++)
{
System.Console.Write(array[i, j] + "\t");
}
System.Console.WriteLine();
}
}
*/

Console.Clear();
void Fill2DArray(int[,] arr)
{
for (int i = 0; i < arr.GetLength(0); i++)
{
for (int j = 0; j < arr.GetLength(1); j++)
{
arr[i, j] = new Random().Next(-10, 100);
}
}
}

void Print2DArray(int[,] array)
{
for (int i = 0; i < array.GetLength(0); i++)
{
for (int j = 0; j < array.GetLength(1); j++)
{
System.Console.Write($"{array[i, j]} ");
}
System.Console.WriteLine();
}
}
int[,] array2D = new int[3, 4];
Fill2DArray(array2D);
Print2DArray(array2D);

/* Console.Clear();

int TakeEnteredNumber(string message)
{
    System.Console.WriteLine(message);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}

string[,] GetIndex2DArray(int row, int column)
{
    string[,] array = new string[row, column];
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
        {
            array[i, j] =($"{i} + {j} = {i + j}");
        }
    }
    return array;
}


void Print2DStringArray(string[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
        System.Console.Write(array[i, j] + "\t");
        }
        System.Console.WriteLine();
    }
}


int userArrayRow = TakeEnteredNumber("Введите количестов строк:");
int userArrayColumn = TakeEnteredNumber("Введите количестов столбцов:");
string[,] user2DIndexArray = GetIndex2DArray(userArrayRow, userArrayColumn);

Print2DStringArray(user2DIndexArray);
*/