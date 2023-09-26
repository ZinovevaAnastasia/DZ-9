// Задача 68. Напишите программу вычисления функции Аккермана с помощью рекурсии.
// Даны два неотрицательных числа m и n.

Console.Write("Введите первое число: ");
int n = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите  второе число: ");
int m = Convert.ToInt32(Console.ReadLine());

if (n < 0 || m < 0)
{
Console.WriteLine("Ошибка ввода!");
return;
}

AckFunction(n,m);

void AckFunction(int n, int m)
{
    Console.Write($"Значение функции Аккермана: A({n};{m}) = {Ack(n, m)}"); 
}

int Ack(int n, int m)
{
    if (n == 0)
    {
        return m + 1;
    }
    else if (m == 0)
    {
        return Ack(n - 1, 1);
    }
    else
    {
        return (Ack(n - 1, Ack(n, m - 1)));
    }
}
