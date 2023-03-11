// 1 задача Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
//Console.Write("Введите 1 число: ");
//int a = Convert.ToInt32(Console.ReadLine()); // Convert.ToInt32 преобразует данные к нужному типу
//Console.Write("Введите 2 число: ");
//int b = Convert.ToInt32(Console.ReadLine());
//int max = a;
//int min = b
//if (max > min)
//{
//  max = a;
//  min = b;
//}
//if (max < min)
//{
//  max = b;
//  min = a
//}
//Console.Write("Максимум = ");
//Console.WriteLine(max);
//Console.Write("Минимум = ");
//Console.WriteLine(min);

// 2 задача  Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел
//Console.Write("Введите 1 число: ");
//int a = Convert.ToInt32(Console.ReadLine()); // Convert.ToInt32 преобразует данные к нужному типу
//Console.Write("Введите 2 число: ");
//int b = Convert.ToInt32(Console.ReadLine());
//Console.Write("Введите 3 число: ");
//int c = Convert.ToInt32(Console.ReadLine());
//int max = a;
//if (max > b)
//{
//  max = a;
//}
//if (max < b)
//{
//  max = b;
//}
//if (max < c)
//{
//  max = c;
//}
//Console.Write("Максимум = ");
//Console.WriteLine(max);

// 3 задача.  Напишите программу, которая на вход принимает число и выдаёт, -
// - является ли число чётным (делится ли оно на два без остатка

//Console.Write("Введите число: ");
//double num = Convert.ToInt32(Console.ReadLine());
//num = num % 2;
//string meaning = "yes"; // задаем переменной "значение" изначально да, 
//                        // что бы уменьшить количество проверок
//if (num > 0)
//{
//    meaning = "no";
//}
//Console.Write("Число четное? Ответ: ");
//Console.WriteLine(meaning);

// 4 задача - Напишите программу, которая на вход принимает число (N), -
// - а на выходе показывает все чётные числа от 1 до N.
Console.Write("Введите число: ");
double num = Convert.ToInt32(Console.ReadLine());
double count = 2;
double number = 0;
while (count <= num)
{
    number = count % 2;
    if (number == 0)
    {
        Console.Write(count);
        Console.Write(", ");
    }
    count++;

}
