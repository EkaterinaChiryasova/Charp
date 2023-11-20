/*
Задайте двумерный массив. Найдите элементы, у
которых оба индекса чётные, и замените эти элементы на их
квадраты.
*/

Console.Clear();

int TakeEnteredNumber(string message)
{
    System.Console.WriteLine(message);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}

int[,] GetRandom2DArray(int start, int end, int row, int column)
{
    int[,] array = new int[row, column];
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
        {
            array[i, j] = new Random().Next(start, end+1);
        }
    }
    return array;
}

int [,] ModifyEvenIndexSquare (int[,] array)
{
    int[,] result = array;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if(i%2 == 0 && j%2 == 0) result [i,j] = array [i,j] * array [i,j];
        }
    }
    return result;
}


void Print2DArray(int[,] array)
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
int userArrayStart = TakeEnteredNumber("Введите начало диапазона:");
int userArrayEnd = TakeEnteredNumber("Введите конец диапазона:");
System.Console.WriteLine();
int[,] user2DArray = GetRandom2DArray(userArrayStart, userArrayEnd, userArrayRow, userArrayColumn);

Print2DArray(user2DArray);
System.Console.WriteLine();
int[,] userNewArray = ModifyEvenIndexSquare(user2DArray);
Print2DArray(user2DArray);
System.Console.WriteLine();
Print2DArray(userNewArray);


/*
int[,] matrix = new int[5, 5];

void FillMatriх(int[,] matrix)
{
for (int i = 0; i < matrix.GetLength(0); i++)
{
for (int j = 0; j < matrix.GetLength(1); j++)
{
matrix[i, j] = new Random().Next(1, 10);
}
}
}

void PrintMatrix(int[,] matrix)
{
for (int i = 0; i < matrix.GetLength(0); i++)
{
for (int j = 0; j < matrix.GetLength(1); j++)
{
System.Console.Write($" {matrix[i, j]} \t");
}
System.Console.WriteLine();
}
}

void FindEvenIndex(int[,] matrix)
{
for (int i = 0; i < matrix.GetLength(0); i += 2)
{
for (int j = 0; j < matrix.GetLength(1); j += 2)
{
matrix[i, j] = matrix[i, j] * matrix[i, j];
}
}
}

FillMatriх(matrix);
PrintMatrix(matrix);
System.Console.WriteLine();
FindEvenIndex(matrix);
PrintMatrix(matrix);
*/

