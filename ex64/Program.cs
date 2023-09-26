// Задача 64: Задайте значение N. Напишите программу,
// которая выведет все натуральные числа в промежутке от N до 1.
// Выполнить с помощью рекурсии.

Console.Write("Введите натуральное число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number < 1)
{
Console.WriteLine("Ошибка ввода!");
return;
}

NaturalNumbers(number);

void NaturalNumbers(int num)
{
if(num == 0) return;
Console.Write($"{num} ");
NaturalNumbers(num - 1);
}
