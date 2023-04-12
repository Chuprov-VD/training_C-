// Задача 54: Задайте двумерный массив. Напишите программу, 
//которая упорядочит по убыванию элементы каждой строки двумерного массива.
//Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

void Matrix(int[,] matr) // создание массива
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(1, 10);
        }
    }
}

void Counting(int[,] matr) // от большего к меньшему
{
    int num = 0;
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            if (j + 1 < matr.GetLength(1) && matr[i, j] < matr[i, j + 1])
            {
                num = matr[i, j];
                matr[i, j] = matr[i, j + 1];
                matr[i, j + 1] = num;
                j = 0;
            }
        }
    }
}

void PrintMatrix(int[,] matr) // печать массива
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]} \t"); // \t - дает отступ
        }
        Console.WriteLine();
    }
}

Console.Clear();
Console.WriteLine("Введите количество строк: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов: ");
int n = Convert.ToInt32(Console.ReadLine());
//int[] size = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray(); // можно так 
//ввести данные размера матрицы
int[,] matr = new int[m, n];
Matrix(matr);
PrintMatrix(matr);
Console.WriteLine();
Counting(matr);
PrintMatrix(matr);

// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая 
// будет находить строку с наименьшей суммой элементов.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 5 2 6 7

// Программа считает сумму элементов в каждой строке и выдаёт номер строки с 
// наименьшей суммой элементов: 1 строка

void Matrix(int[,] matr) // создание массива
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(1, 10);
        }
    }
}

void Counting(int[,] matr) // от большего к меньшему
{
    int num = 0;
    int numMin = 999999999;
    int count = 0;
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {

            num = matr[i, j] + num;

        }
        if (num < numMin)
        {
            numMin = num;
            count = i + 1;
        }
        num = 0;
    }
    Console.WriteLine($" c наименьшой суммой элементов: {count} строка");
}

void PrintMatrix(int[,] matr) // печать массива
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]} \t"); // \t - дает отступ
        }
        Console.WriteLine();
    }
}

Console.Clear();
Console.WriteLine("Введите количество строк: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов: ");
int n = Convert.ToInt32(Console.ReadLine());
//int[] size = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray(); // можно так 
//ввести данные размера матрицы
int[,] matr = new int[m, n];
Matrix(matr);
PrintMatrix(matr);
Console.WriteLine();
Counting(matr);

// Задача 58: Задайте две матрицы. Напишите программу, 
// которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4 строки * столбцы
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

void Matrix(int[,] matr1, int[,] matr2) // создание матриц
{
    for (int i = 0; i < matr1.GetLength(0); i++)
    {
        for (int j = 0; j < matr1.GetLength(1); j++)
        {
            matr1[i, j] = new Random().Next(1, 10);
            matr2[i, j] = new Random().Next(1, 10);
        }
    }
}

void Multi(int[,] matr1, int[,] matr2, int[,] resault) // от большего к меньшему
{
    for (int i = 0; i < matr1.GetLength(0); i++)
    {
        for (int j = 0; j < matr1.GetLength(1); j++)
        {
            int sum = 0;
            for (int k = 0; k < matr1.GetLength(1); k++)
            {
                sum = matr1[i, k] * matr2[k, j] + sum;
            }
            resault[i, j] = sum;
        }
    }
}

void PrintMatrix(int[,] matr) // печать массива
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]} \t"); // \t - дает отступ
        }
        Console.WriteLine();
    }
}

Console.Clear();
Console.WriteLine("Введите количество строк: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов: ");
int n = Convert.ToInt32(Console.ReadLine());
//int[] size = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray(); // можно так 
//ввести данные размера матрицы
int[,] matr1 = new int[m, n];
int[,] matr2 = new int[m, n];
int[,] resault = new int[m, n];
Matrix(matr1, matr2);
PrintMatrix(matr1);
Console.WriteLine();
PrintMatrix(matr2);
Console.WriteLine("Произведение 2-х матриц равно: ");
Multi(matr1, matr2, resault);
PrintMatrix(resault);


Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
Напишите программу, которая будет построчно выводить массив,
добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0, 1, 0)
34(1, 0, 0) 41(1, 1, 0)
27(0, 0, 1) 90(0, 1, 1)
26(1, 0, 1) 55(1, 1, 1)

Console.Clear();
void FillMat(int[,,] mat)
{
    int count = 10;
    for (int i = 0; i < mat.GetLength(0); i++)
    {
        for (int j = 0; j < mat.GetLength(1); j++)
        {
            for (int k = 0; k < mat.GetLength(2); k++)
            {
                mat[k, i, j] += count;
                count += 3;
            }
        }
    }
}

void PrintIndex(int[,,] mat)
{
    for (int i = 0; i < mat.GetLength(0); i++)
    {
        for (int j = 0; j < mat.GetLength(1); j++)
        {
            Console.WriteLine();
            for (int k = 0; k < mat.GetLength(2); k++)
            {
                Console.Write($"{mat[i, j, k]}({i},{j},{k}) ");
            }
        }
    }
}



int[,,] matrix3D = new int[2, 2, 2];
FillMat(matrix3D);
PrintIndex(matrix3D);
Console.WriteLine();

// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
//Например, на выходе получается вот такой массив:
//01 02 03 04
//12 13 14 05
//11 16 15 06
//10 09 08 07

Console.Clear();
void FillMatrixSpiral(int[,] matrix, int n)
{
    int i = 0, j = 0;
    int value = 1;
    for (int e = 0; e < n * n; e++)
    {
        int k = 0;
        do { matrix[i, j++] = value++; } while (++k < n - 1);
        for (k = 0; k < n - 1; k++) matrix[i++, j] = value++;
        for (k = 0; k < n - 1; k++) matrix[i, j--] = value++;
        for (k = 0; k < n - 1; k++) matrix[i--, j] = value++;
        ++i; ++j;
        n = n < 2 ? 0 : n - 2;
    }
}


void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (matrix[i, j] < 10)
            {
                Console.Write("0" + matrix[i, j]);
                Console.Write(" ");
            }
            else Console.Write(matrix[i, j] + " ");
        }
        Console.WriteLine();
    }
}

int len = 4;
int[,] table = new int[len, len];
FillMatrixSpiral(table, len);
PrintMatrix(table);