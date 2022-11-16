/*Задайте значение N. Напишите программу, которая выведет 
все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.*/

Console.WriteLine("Введите число N");
int num = int.Parse(Console.ReadLine()!);

string PrintNumbers(int num)
{
    if (num == 1) 
        return num.ToString();

    else
    {
        Console.Write ((num) + ",");
        num = (num-1);
        return PrintNumbers (num);
         
    }
}

Console.WriteLine(PrintNumbers(num));