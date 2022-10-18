/*Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N. Рекурсивно
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30*/

Console.Clear();
Console.WriteLine("Введите положительное целое число M:");
int numM = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите положительное целое число N:");
int numN = int.Parse(Console.ReadLine()!);

if(numM > numN){
    int temp = numM;
    numM = numN;
    numN = temp;
}

int result = 0;
Sum(numM,numN);
Console.WriteLine($"Сумма натуральных элементов равна: {result}");

int Sum (int numM, int numN)
    {
        
        if (numM <= numN){
        result = result + numN;
        numN--;
        return Sum(numM, numN);
        }
        return result;        
    }