// 1 задача Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
//Console.Write("Введите 1 число: ");
//int a = Convert.ToInt32(Console.ReadLine()); // Convert.ToInt32 преобразует данные к нужному типу
//Console.Write("Введите 2 число: ");
//int b = Convert.ToInt32(Console.ReadLine());
//int max = a;
//if (max > b)
//{
//  max = a;
//}
//if (max < b)
//{
//  max = b;
//}
//Console.Write("Максимум = ");
//Console.WriteLine(max);

// 2 задача  Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел
Console.Write("Введите 1 число: ");
int a = Convert.ToInt32(Console.ReadLine()); // Convert.ToInt32 преобразует данные к нужному типу
Console.Write("Введите 2 число: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите 3 число: ");
int c = Convert.ToInt32(Console.ReadLine());
int max = a;
if (max > b)
{
    max = a;
}
if (max < b)
{
    max = b;
}
if (max < c)
{
    max = c;
}
Console.Write("Максимум = ");
Console.WriteLine(max);