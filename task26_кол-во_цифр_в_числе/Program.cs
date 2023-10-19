/*
Напишите программу, которая принимает на вход число 
и выдаёт количество цифр в числе.
456 -> 3
78 -> 2
89126 -> 5
*/

System.Console.WriteLine("Введите число: ");
int userNumber = Convert.ToInt32(System.Console.ReadLine());

/*int count = 0;

for (int i = number; i > 0; i /= 10)
{
    count = count + 1;
}
*/

int Result(int number)
{
    int count = 0;
    for (int i = number; i > 0; i /= 10)
    {
        count = count + 1;
    }
    return(count)
}
int userCount = Result(userNumber);
System.Console.WriteLine(userCount);