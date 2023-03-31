//Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2

void InputArray(int[] array, ref int count) // процедура void
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(100, 1000);
        if (array[i] % 2 == 0)
        {
            count++; // считает все четные числа
        }
    }
}

Console.Clear();
Console.Write($"Введите число которое задаст, количество чисел в массиве: ");
int number = Convert.ToInt32(Console.ReadLine());
int[] array = new int[number]; // создаем пустой массив
int count = 0;
InputArray(array, ref count); // вызов метода + ссылка на счет(на массив ссылку можно не добовлять)
Console.WriteLine($"[{string.Join(", ", (array))}] -> {count}"); // string.Join для передачи 
//процедуры void, и для добавления запятых

//Задача 36: Задайте одномерный массив, заполненный случайными числами. 
//Найдите сумму элементов, стоящих на нечётных позициях.

//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> 0

void InputArray(int[] array, ref int count) // процедура void
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(-100, 100);
        if (array[i] % 2 != 0)
        {
            count = array[i] + count;
        }
    }
}

Console.Clear();
Console.Write($"Введите число которое задаст, количество чисел в массиве: ");
int number = Convert.ToInt32(Console.ReadLine());
int[] array = new int[number];
int count = 0;
InputArray(array, ref count); // вызов метода + ссылка на счет(на массив ссылку можно не добовлять)
Console.WriteLine($"[{string.Join(", ", (array))}] -> {count}");

//Задача 38: Задайте массив вещественных чисел. 
//Найдите разницу между максимальным и минимальным элементов массива.

//[3 7 22 2 78] -> 76

void InputArray(double[] array, ref double max, ref double min) // процедура void
{

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(-100, 100);
        if (array[i] > max)
        {
            max = array[i];
        }
    }
    min = max;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < min)
        {
            min = array[i];
        }
    }
}

Console.Clear();
Console.Write($"Введите число которое задаст, количество чисел в массиве: ");
int number = Convert.ToInt32(Console.ReadLine());
double[] array = new double[number];
double max = 0;
double min = 100;
InputArray(array, ref max, ref min); // вызов метода + ссылка на счет(на массив ссылку можно не добовлять)
Console.WriteLine($"[{string.Join(" ", (array))}] -> {max - min}");