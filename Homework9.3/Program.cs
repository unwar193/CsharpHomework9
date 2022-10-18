/*Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9;      m = 3, n = 2 -> A(m,n) = 29*/

Console.Clear();
Console.WriteLine("Введите неотрицательное число m: ");
int m = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите неотрицательное число n: ");
int n = int.Parse(Console.ReadLine()!);

Console.WriteLine($"A(m,n) = {AckermanFunc(m, n)}");

int AckermanFunc(int numM, int numN)
{
    if (numM == 0)
    {
        return numN + 1;
    }
    if (numM > 0 && numN == 0)
    {
        return AckermanFunc(numM - 1, 1);
    }
    if (numM > 0 && numN > 0)
    {
        return AckermanFunc(numM - 1, AckermanFunc(numM, numN - 1));
    }
    return AckermanFunc(numN, numM);
}