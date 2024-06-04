// Задача 1: Задайте значения M и N. 
// Напишите программу, которая выведет все натуральные числа в промежутке от M до N. 
// Использовать рекурсию, не использовать циклы.

void PrintNaturalNumbers(int m, int n)
{
    if (m == n)
    {
        Console.Write($"{m}");
        return;
    }
    else if (m > n)
    {
        Console.Write($"{n} ");
        PrintNaturalNumbers(m, n + 1);
    }
    else if (m < n)
    {
        Console.Write($"{m} ");
        PrintNaturalNumbers(m + 1, n);
    }

}

Console.WriteLine("Введите начало промежутка(M): ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите конец промежутка(N): ");
int n = Convert.ToInt32(Console.ReadLine());
PrintNaturalNumbers(m, n);