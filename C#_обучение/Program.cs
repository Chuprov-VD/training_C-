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
//**if (max > min)
//**{
//**    max = a;
//**    min = b;
//**}
//**if (max < min)
//**{
//**    max = b;
//**    min = a;
//**}
//**Console.Write("Максимум = ");
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
//**Console.Write("Максимум = ");
//**Console.WriteLine(max);

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

//11. Поиск максимума с помощью метода
int Max(int arg1, int arg2, int arg3) //    данный метод (название задается самостоятельно) который придуман от начала и до конца, -
// - берет три производных числа и ищет максимум int arg - (условная переменная, в которую можно положить любое значение)
{
    int resault = arg1; // resault - переменная результат, которой присваевается 1 значение
    if (arg2 > resault) resault = arg2; // сравнение 2 переменной с 1-ой если 2 > 1, то resault присваевается 2 переменная
    if (arg3 > resault) resault = arg3; // сравнение 3 с resault
    return resault; // возвращает результат
}
int a1 = 1; // 1 группа
int b1 = 5;
int c1 = 62;
int a2 = 12; // 2 группа
int b2 = 532;
int c2 = 6;
int a3 = 14; // 3 группа
int b3 = 4;
int c3 = 65;
// метод названный Max() возвращает результат примененного алгоритма выше
int max1 = Max(a1, b1, c1); // сравнение 1 группы
int max2 = Max(a2, b2, c2); // сравнение 2 группы
int max3 = Max(a3, b3, c3);// сравнение 3 группы
int max = Max(max1, max2, max3); // сравнение результатов группы
Console.WriteLine(max); // печатает результат

