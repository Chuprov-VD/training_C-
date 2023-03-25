﻿//* - пишится перед кодом (который можно разкоментить)

// 1. Вывод через консоль приветствие Console - обращение к консоле; 
//.WriteLin - команда для печати на экран
//*Console.WriteLine("Hello, World!"); 

// 2. Просьба ввести данные у пользователя и поприветствовать его
//*Console.WriteLine("Введите Ваше имя");
// string - тип данных (строка) добавляется перед переменной
//*string username = Console.ReadLine();
// username - имя пользователя; Console - обращение к консоле; .Readline - команда для ввода данных
//*Console.WriteLine("Привет, "); // выводит - Привет, 
//*Console.WriteLine(username); // выводит содержание переменной username

// 3. Write - позволяет ввыводить на экран текст в одну строку,в отличии от предыдущей команды WriteLine 
// - печатала текст, и далее следующая команда, выводилась уже на следующей строке
//*Console.Write("Введите Ваше имя ");
// string - тип данных (строка) добавляется перед переменной
//*string username = Console.ReadLine();
// username - имя пользователя; Console - обращение к консоле; .Readline - команда для ввода данных
//*Console.Write("Привет, "); // выводит - Привет, 
//*Console.Write(username); // выводит содержание переменной username

// 4. складываем числа
//*int numberA = 21; // обязательно перед началом переменной назначить тип строки 
// - ( в данном типе int - числовой тип)
//*int numberB = 5; // допускается писать переменные заглавными и строчными буквами.
//*int resault = numberA + numberB;
//*Console.WriteLine(resault);

// 5. деление числа 
//*int numberA = 13; // Если перед переменной задать тип данных int - то деление буде целочисленным
//*int numberB = 3;
//*int run = numberA / numberB;
//*Console.WriteLine(run);

//*double numberC = 13; // Для раделения с плавующей точкой используется тип данных double
//*double numberG = 3;
//*double runB = numberC / numberG;
//*Console.WriteLine(runB);

// 6. получение случайного целого числа
//*int num = new Random().Next(1, 1000); // переменной num с типом данных int присвается случайное - 
// - значение от 1 до 1000
//*Console.WriteLine(num); // вывод полученного числа

// 7. Цикл (if, else)
//*Console.WriteLine("Привет, введи пожалуйсто свое имя: ");
//*string username = Console.ReadLine();
//*if (username.ToLower == "маша") // каждое услови е цикла нужно выделить { } так, .ToLower - 
// -  преобразует значение к нижнему регистру 
//*{
//*    Console.WriteLine("Привет, МАША, УРА!");
//*}
//*else
//*{
//*    Console.WriteLine("Привет");
//*}

//8. Решение задачи с гирями
//* int a = 1; // первая гиря
//* int b = 8; // вторая гиря
//* int c = 3; // третья гиря
//* int d = 6; // четверта гиря
//* int e = 2; // пятая гиря
//* int max = a; // ставим флаг на 1 гирю
//* if (a > max) max = a; // проверяем
//*if (b > max) max = b;
//* if (c > max) max = c;
//* if (d > max) max = d;
//* if (e > max) max = e;

//* Console.Write("Привет, max = "); // для того что бы уместилось на 1 строке пишем данную команду
//* Console.WriteLine(max); // выводим результат

// 9. Работа с циклом while

//**Console.Clear(); // очищает консоль(терминал, от других записей)
//*Console.SetCursorPosition(10, 4); // делает отступ ((нумеруются с 0)слева символы, сверху строки)
//*Console.WriteLine("+"); // выводит в терминал записаное значение

//**int xa = 40, xb = 1, xc = 80, // допускается хначения переменных записывать через запятую - 
//**ya = 1, yb = 30, yc = 30; //  - но, сначала требуется задать тип данных

//Console.SetCursorPosition(xa, ya);// делает отступ ((нумеруются с 0)слева символы, сверху строки)
//Console.WriteLine("+");
//Console.SetCursorPosition(xb, yb);
//Console.Write("+"); // что бы основание было на одной строке пишем .Write
//Console.SetCursorPosition(xc, yc);
//Console.WriteLine("+");

//**int x = xa, y = xb;

//**int count = 0; // счетчик что бы цикл был не бесконечный

//**while (count < 10000) // цикл, со значением до выхода, count = 10000 конец цикла
//**{
//**int num = new Random().Next(0, 3); // [0, 1, 2] выбодение одного из 3 чисел
//**if (num == 0)
//**{
//**x = (x + xa) / 2; // середина точки
//**y = (y + ya) / 2;
//**}
//**if (num == 1)
//**{
//**x = (x + xb) / 2;
//**y = (y + yb) / 2;
//**}
//**if (num == 2)
//**{
//**x = (x + xc) / 2;
//**y = (y + yc) / 2;
//**}
//**Console.SetCursorPosition(x, y); // адрес "+" x - отступ слева, y - строка
//**Console.Write("+"); // обязательно, если хотим получить не космическое поле
//**count++; // count после 1 значения плюсуется + 1 (для конечности цикла)
//**} 

//10. семинар
// 1 задача Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
//**Console.Write("Введите 1 число: ");
//**int a = Convert.ToInt32(Console.ReadLine()); // Convert.ToInt32 преобразует данные к нужному типу
//**Console.Write("Введите 2 число: ");
//**int b = Convert.ToInt32(Console.ReadLine());
//**int max = a;
//**int min = b;
//**
//**if (max < min)
//**{
//**    max = b;
//**    min = a;
//**}
//!**Console.Write("Максимум = "); // Console.Write($"Максимум = {max}"); - выводит результат по другому
//**Console.WriteLine(max);
//**Console.Write("Минимум = ");
//**Console.WriteLine(min);

// 2 задача  Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел

//**Console.Write("Введите 1 число: ");
//**int a = Convert.ToInt32(Console.ReadLine()); // Convert.ToInt32 преобразует данные к нужному типу
//**Console.Write("Введите 2 число: ");
//**int b = Convert.ToInt32(Console.ReadLine());
//**Console.Write("Введите 3 число: ");
//**int c = Convert.ToInt32(Console.ReadLine());
//**int max = a;
//**if (max > b)
//**{
//**    max = a;
//**}
//**if (max < b)
//**{
//**    max = b;
//**}
//**if (max < c)
//**{
//**    max = c;
//**}
//**Console.WriteLine($"Максимум = {max} ");

// 3 задача.  Напишите программу, которая на вход принимает число и выдаёт, -
// - является ли число чётным (делится ли оно на два без остатка

//**Console.Write("Введите число: ");
//**double num = Convert.ToInt32(Console.ReadLine());
//**num = num % 2;
//**string meaning = "yes"; // задаем переменной "значение" изначально да, 
// что бы уменьшить количество проверок
//**if (num > 0)
//**{
//**    meaning = "no";
//**}
//**Console.Write("Число четное? Ответ: ");
//**Console.WriteLine(meaning);

// 4 задача - Напишите программу, которая на вход принимает число (N), -
// - а на выходе показывает все чётные числа от 1 до N.
//**Console.Write("Введите число: ");
//**double num = Convert.ToInt32(Console.ReadLine());
//**double count = 2;
//**double number = 0; // промежуточная переменная
//**while (count <= num)
//**{
//**    number = count % 2;
//**   if (number == 0)
//**    {
//**        Console.Write(count);
//**        Console.Write(", ");
//**    }
//**    count++;
//**}


// 4.1 задача - Напишите программу, которая на вход принимает число (N), -
// - а на выходе показывает все чётные числа от 1 до N. 
//*Console.Write("Введите число: ");
//*double num = Convert.ToInt32(Console.ReadLine());
//*for (double i = 2; i <= num; i+= 2)
//*     Console.Write($"{i}, ");


//11. Поиск максимума с помощью метода
//*int Max(int arg1, int arg2, int arg3) //    данный метод (название задается самостоятельно) который придуман от начала и до конца, -
// - берет три производных числа и ищет максимум int arg - (условная переменная, в которую можно положить любое значение)
//*{
//*    int resault = arg1; // resault - переменная результат, которой присваевается 1 значение
//*    if (arg2 > resault) resault = arg2; // сравнение 2 переменной с 1-ой если 2 > 1, то resault присваевается 2 переменная
//*    if (arg3 > resault) resault = arg3; // сравнение 3 с resault
//*    return resault; // возвращает результат
//*}
//*int a1 = 1; // 1 группа
//*int b1 = 5;
//*int c1 = 62;
//*int a2 = 12; // 2 группа
//*int b2 = 532;
//*int c2 = 6;
//*int a3 = 14; // 3 группа
//*int b3 = 4;
//*int c3 = 65;
// метод названный Max() возвращает результат примененного алгоритма выше
//*int max1 = Max(a1, b1, c1); // сравнение 1 группы
//*int max2 = Max(a2, b2, c2); // сравнение 2 группы
//*int max3 = Max(a3, b3, c3);// сравнение 3 группы
//*int max = Max(max1, max2, max3); // сравнение результатов группы
//*Console.WriteLine(max); // печатает результат

//12. - Использованеи массива

//*int[] array = { 1, 28, 33, 42, 15, 68, 47, 38, 19 }; // массив
//*int n = array.Length; //.Length - возвращает кол-во элементов массива
//*int find = 15; // значение индекс которого требуется найти
//*int index = 0; // для поиска значения задаем 0 индекс
//*while (index < n) // условие выполняется пока индекс меньше количества символов массива
//*{
//*    if (array[index] == find) // сравниваем значения индекса массива и нужный - 
//    - показатель, если они совпадают то выполняется условия
//*    {
//*        Console.WriteLine(index);
//*        break; //после выполнения условия цикл прекращается 
//*    }

//*    index++; // что бы цикл был не бесконечный
//*}
//*Console.WriteLine(n); // возвращает 4 символ из массива нумерация идет с 0, 

//*12 - Семинар ДЗ
// 4 задача - Напишите программу, которая на вход принимает число (N), -
// - а на выходе показывает все чётные числа от 1 до N.
//Console.Write("Введите число: ");
//double num = Convert.ToInt32(Console.ReadLine());
//for (double i = 2; i <= num; i++)
//    if (i % 2 == 0)
//        Console.Write($"{i}, ");

//1. Семинар Массив
//Console.Clear();
//int[] array = new int[3];
//for (int i = 0; i < array.Length; i++)
//    array[i] = new Random().Next(-10, 11);

//Console.WriteLine($"[{string.Join(", ", array)}]");// преобразует к строке, что бы данные можно было вывести

//Задача 10: Напишите программу, которая принимает на вход трёхзначное число и 
//на выходе показывает вторую цифру этого числа.

//Console.Clear();
//Console.Write("Ведите число: ");
//string num = Console.ReadLine();
//Console.WriteLine(num[1]);

//Задача 13: Напишите программу, которая выводит третью цифру заданного числа 
//или сообщает, что третьей цифры нет.

//Console.Clear();
//Console.Write("Ведите число: ");
//string num = Console.ReadLine();
//if (num.Length < 3)
//{
//    Console.WriteLine("3 числа нет");
//}
//else
//{
//    Console.WriteLine(num[2]);
//}


//*13. - void метод (не до конца)
//void FillArray(int[] collection) // создаем новый метод
//{
//    int length = collection.Length;
//    int index = 0;
//    while (index < length)
//    {
//        collection[index] = new Random().Next(1, 10);
//        index++;
//    }
//}

//int[] array = new int[10];// в пустой массив положи 10 элементов

//14 - семинар

// 14.1 array
//Console.Clear(); // очищает консоль
//int[] array = new int[8]; // создает пустой массив числовой  с возможным заполнение 8 чисел
//for (int i = 0; i < array.Length; i++) // цикл который добовляет в список новое рандомное число
//    array[i] = new Random().Next(-10, 11); // [-10, 10] новое рандомное число в диапазоне i - индекс

//Console.WriteLine($"[{string.Join(", ", array)}]"); //вывод массива, без функции string.Join 
//вывводится ни чего не будет


//14.2 процедуры - (void) процедуры не возвращают значение

//Console.Clear();
//void f(ref int n) // ref - означает ссылку
//{
//    n = n + 12;
//}
//int n = 5;
//Console.WriteLine(n);
//f(ref n); //передали значение n через ref в метод voit, и он посчитал.
//Console.WriteLine(n);

//14.3 функция

//Console.Clear();

//int f(int x, int y)
//{
//    if (x > y)

//        return x; // возвращает значение и прерывает работу функции

// else не нужен, так как если предыдущее правильно функция прервется

//    return y;

//}

//int n = 6;
//int n1 = 13;
//int max = f(n, n1); // в переменную макс записываем максимальное значение
//Console.WriteLine($"Максимум равен: {max} ");



//14.55 Последовательность фибоначчи

// Последовательность Фибоначчи – это последовательность 
// натуральных чисел, где каждое последующее число является суммой двух предыдущих

//Console.Clear();

//int a = 1;
//int b = 0;
//int c = 0;
//Console.Write("Введите желаемую продолжительность последовательности: ");
//int number = Convert.ToInt32(Console.ReadLine());
//for (int i = 0; i < number; i++)
//{
//    c = b;
//    b = b + a;
//    a = c;
//    Console.Write($"{b}, "); // выводим последовательность
//}

// 15.6 Задача из семинара

//15.61 Напишите программу которая генерирует рандомное число в диапазоне от [10, 99], 
//и следом выводит максимальное из 2 чисел

// Например:
// - 76 -> 7;
// -78 -> 8;
// 64 -> 6;

//int f(int x, int y) // задаем начало метода
//{
//    if (x > y) // условия функции используются любые переменные, но одного типа
//    {
//        return x;
//    }           // else - не нужен так как при выполнении if функция прервется
//    return y;
//}

//int num = new Random().Next(10, 100); // от 10 до 99 последнее число не пишется
//int n = num / 10;
//int b = num % 10;
//int max = f(n, b);
//Console.WriteLine($"Рандомное число: {num}");
//Console.WriteLine($"Максимальное из рандомного числа: {max}");

// 15.62 ДЗ 3

//Console.Write($"Введите число: ");
//int num1 = Convert.ToInt32(Console.ReadLine()); // ввод 1 числа
//Console.Write("Введите степень в которую ходтите возвести: ");
//int num2 = Convert.ToInt32(Console.ReadLine()); // ввод 2 числа
//Console.WriteLine($"Число {num1}, в степени {num2} = {Math.Pow(num1, num2)}");

// 15.64 ДЗ 3
//Console.Clear();
//int num = Convert.ToInt32(Console.ReadLine());
//for (int i = 0; i < num; i++ )
//int c = num / 100;
//int n = (num - c * 100) / 10;
//int b = num % 10;
//int summa = c + b + n;
//Console.WriteLine($"Сумма чисел равна: {summa}");

//15.65 задача из семинара
//Напишите программу которая выводит случайное трех значное число 
//и удаляет вторую цифру из этого числа 

//Console.Clear();
//int num = new Random().Next(100, 1000); // от 100, до 999 
//Console.WriteLine($"Рандомное трех значное число равно: {num}");
//int c = num / 100;
//int n = num % 10;
//Console.WriteLine($"Число без средней цифры равно: {c}{n}");

// Напишите программу, которая будет принимать на вход два числа и выводить, 
// является ли второе число кратным первому. Если число 2 не кратно числу 1, 
// то программа выводит остаток от деления.
// 34, 5 -> не кратно, остаток 4
// 16, 4 -> кратно

Console.Clear();
Console.WriteLine($"Введите 1 число: ");
string num1 = Console.ReadLine(); // вводим сначала число в формате строки
double number1 = Convert.ToDouble(num1);// преобразуем строку в вещественное число
Console.WriteLine($"Введите 2 число: ");
string num2 = Console.ReadLine();
double number2 = Convert.ToDouble(num2);
double resault = number1 / number2;
double num3 = resault * 10 % 10; // выводим остаток от деления, в целое число
Console.WriteLine($"Число после деления: {resault}");
if (num3 > 0)
{
    Console.WriteLine($"Число не кратно, остаток {num3}");
}
else
{
    Console.WriteLine($"Число кратно");
}
