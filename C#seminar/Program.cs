Console.Write("Введите 1 число: ");
int a = Convert.ToInt32(Console.ReadLine()); // Convert.ToInt32 преобразует данные к нужному типу
Console.Write("Введите 2 число: ");
int b = Convert.ToInt32(Console.ReadLine());
int max = a;
if (max > b)
{
    max = a;
}
if (max < b)
{
    max = b;
}
Console.Write("Максимум = ");
Console.WriteLine(max);