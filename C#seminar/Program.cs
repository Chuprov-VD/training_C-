// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

Console.Clear();

void PrintArry(double[,] matr) //(метод для вывода матрицы)
{
    for (int rows = 0; rows < matr.GetLength(0); rows++) // matrix.GetLength(0) - обращается к количесвту строк
    {
        for (int columns = 0; columns < matr.GetLength(1); columns++) //GetLength(1) - обращается к количеству столбцов 
        {
            Console.Write($"{matr[rows, columns]} "); // для вывода строки столбца
        }
        Console.WriteLine(); // пробел для красивого вывода 2 строки и так далее
    }
}


void FillArray(double[,] matr)
{
    for (int rows = 0; rows < matr.GetLength(0); rows++) // matrix.GetLength(0) - обращается к количесвту строк
    {
        for (int columns = 0; columns < matr.GetLength(1); columns++) //GetLength(1) - обращается к количеству столбцов 
        {
            int num = new Random().Next(-9, 10);
            matr[rows, columns] = Math.Round(new Random().NextDouble() * num, 2);
        }
    }
}

double[,] matrix = new double[3, 4];
FillArray(matrix);
PrintArry(matrix);

// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:

// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
//17 -> такого числа в массиве нет

Console.Clear();

void PrintArry(int[,] matr, int num, int flag) //(метод для вывода матрицы)
{
    for (int rows = 0; rows < matr.GetLength(0); rows++) // matrix.GetLength(0) - обращается к количесвту строк
    {
        for (int columns = 0; columns < matr.GetLength(1); columns++) //GetLength(1) - обращается к количеству столбцов 
        {
            Console.Write($"{matr[rows, columns]} "); // для вывода строки столбца
            if (matr[rows, columns] == num) flag++;
        }
        Console.WriteLine(); // пробел для красивого вывода 2 строки и так далее
    }
    if (flag == 0) Console.WriteLine($"{num} -> такого числа в массиве нет");
    else Console.WriteLine($"{num} -> такое число в массиве есть, оно повторяется {flag} раз");
}


void FillArray(int[,] matr)
{
    for (int rows = 0; rows < matr.GetLength(0); rows++) // matrix.GetLength(0) - обращается к количесвту строк
    {
        for (int columns = 0; columns < matr.GetLength(1); columns++) //GetLength(1) - обращается к количеству столбцов 
        {
            matr[rows, columns] = new Random().Next(1, 30);
        }
    }
}

int[,] matrix = new int[3, 4];
Console.Write("Ввыедите число для поиска: ");
int num = Convert.ToInt32(Console.ReadLine());
int flag = 0;
FillArray(matrix);
PrintArry(matrix, num, flag);

// Задача 52. Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3

void FillArray(int[,] matr, int line, double[] array)
{
    for (int columns = 0; columns < matr.GetLength(1); columns++) // matrix.GetLength(0) - обращается к количесвту строк
    {
        double num = 0;
        for (int rows = 0; rows < matr.GetLength(0); rows++) //GetLength(1) - обращается к количеству столбцов 
        {
            matr[rows, columns] = new Random().Next(1, 10);
            num = matr[rows, columns] + num;
        }
        array[columns] = Math.Round(num / line, 1);
    }
    Console.WriteLine($"Среднее арифметическое каждого столбца: {string.Join("; ", array)}; {line}");
}
void PrintArry(int[,] matr) //(метод для вывода матрицы)
{
    for (int rows = 0; rows < matr.GetLength(0); rows++) // matrix.GetLength(0) - обращается к количесвту строк
    {
        for (int columns = 0; columns < matr.GetLength(1); columns++) //GetLength(1) - обращается к количеству столбцов 
        {
            Console.Write($"{matr[rows, columns]} "); // для вывода строки столбца
        }
        Console.WriteLine(); // пробел для красивого вывода 2 строки и так далее
    }
}


Console.Clear();
Console.Write("Введите количество строк: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int columns = Convert.ToInt32(Console.ReadLine());
int[,] matrix = new int[rows, columns];
double[] array = new double[columns];


FillArray(matrix, rows, array);
PrintArry(matrix);