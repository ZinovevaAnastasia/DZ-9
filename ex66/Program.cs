// Задача 66: Задайте значения M и N. Напишите программу,
// которая найдёт сумму натуральных элементов в промежутке от M до N.
// Выполнить с помощью рекурсии.

Console.Write("Введите первое натуральное число: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе натуральное число: ");
int n = Convert.ToInt32(Console.ReadLine());

if (m < 1 || n < 1)
{
Console.WriteLine("Ошибка ввода!");
return;
}

SumFromMToN(m, n);

void SumFromMToN(int m, int n)
{
    if (m < n)
    {
        Console.Write($"Сумма натуральных чисел от {m} до {n} равна {SumMN(m - 1, n)}");
    }
    else
    {
        Console.Write($"Сумма натуральных чисел от {n} до {m} равна {SumMN(n - 1, m)}");
    }
}

int SumMN(int m, int n)
{
    int res = m;
    if (m == n)
        return 0;
    else
    {
        m++;
        res = m + SumMN(m, n);
        return res;
    }
}