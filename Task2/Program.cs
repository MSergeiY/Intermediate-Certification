// Задача 2: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.

int AckermanFunc(int n, int m)
{
    if (n == 0) return m + 1;
    if (m == 0) return AckermanFunc(n - 1, 1);
    return AckermanFunc(n - 1, AckermanFunc(n, m - 1));
}

int n = 3;
int m = 11;
Console.WriteLine(AckermanFunc(n, m));