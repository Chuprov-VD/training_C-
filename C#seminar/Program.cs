// // Задача 64: Задайте значение N. Напишите программу, которая выведет 
// // все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

// // N = 5 -> "5, 4, 3, 2, 1"
// // N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

void NumNatur(int n)
{
    if (n > 0)
    {
        Console.Write($"{n}");
        if (n > 1) Console.Write(", ");
        n--;
        NumNatur(n);
    }
    else Console.WriteLine();
}

Console.Clear();
Console.WriteLine("Введите натуральное число последовательность которой хотите получить от N до 1: ");
int num = Convert.ToInt32(Console.ReadLine());
Console.Write($"N = {num} -> ");
NumNatur(num);

// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт 
// сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

void NumNatur(int n1, int n2, int sum)
{
    if (n1 == n2)
    {
        Console.WriteLine(sum);
    }
    if (n1 > n2)
    {
        sum = n1 + sum;
        n1--;
        NumNatur(n1, n2, sum);
    }
    if (n1 < n2)
    {
        sum = n2 + sum;
        n2--;
        NumNatur(n1, n2, sum);
    }

}

Console.Clear();
Console.WriteLine("Введите натуральные числа сумму которых хотите получить от N до M: ");
Console.WriteLine();
Console.Write("Введите число N: ");
int numN = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число M: ");
int numM = Convert.ToInt32(Console.ReadLine());
Console.Write($"M = {numM}; N = {numN} -> ");
int sum = 0;
NumNatur(numN, numM, sum);

//Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии.
//Даны два неотрицательных числа m и n.
//m = 2, n = 3 -> A(m,n) = 9
//m = 3, n = 2 -> A(m,n) = 29



int Ack(int m, int n)
{
    if (m == 0) return n + 1;
    else if (n == 0) return Ack(m - 1, 1);
    else return Ack(m - 1, Ack(m, n - 1));
}

int InputNumbers(string input)
{
    Console.Write(input);
    int output = Convert.ToInt32(Console.ReadLine());
    return output;
}

int m = InputNumbers("Введите M: ");
int n = InputNumbers("Введите N: ");

int functionAkkerman = Ack(m, n);

Console.WriteLine($"Функция Аккермана = {functionAkkerman} ");