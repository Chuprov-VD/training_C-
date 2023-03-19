
//Задача 19

//Напишите программу, которая принимает на вход пятизначное число и проверяет, 
//является ли оно палиндромом...

Console.Clear();
Console.Write("Введите число: ");
string num = Console.ReadLine();
int f = num.Length;
int count = -1;
int i = -1;
while (i < f)
{
    f = f - 1;
    i++;
    if (num[i] == num[f])
    {
        count++;
    }
}
if (count == num.Length / 2)
{
    Console.Write("Да, число является палиндромом ");
}
else
{
    Console.WriteLine("Нет, число не является палидромом ");
}
//

//Задача 21
//Напишите программу, которая принимает на 
//вход координаты двух точек и находит расстояние между ними в 3D пространстве.

//Задача 23
//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
Console.Clear();
Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
for (int i = 1; i <= num; i++)
    Console.Write($"{Math.Pow(i, 3)} ");