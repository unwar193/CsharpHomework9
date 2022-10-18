/*Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"*/
Console.Clear();
Console.WriteLine("Введите положительное целое число N:");
int num = int.Parse(Console.ReadLine()!);

Rec(num);
int Rec (int num)
    {           
        if (num >= 1){
        Console.Write($"{num} ") ;
        return Rec(num - 1);
        }
        else {
            return 0;
        }
    }