//* - пишится перед кодом (который можно разкоментить)

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

// Console.Clear();

// double a = 1;
// double b = 0;
// double c = 0;
// Console.Write("Введите желаемую продолжительность последовательности: ");
// double number = Convert.ToDouble(Console.ReadLine());
// for (int i = 0; i < number; i++)
// {
//     c = b;
//     b = b + a;
//     a = c;
//     Console.Write($"{b}, "); // выводим последовательность
// }
// Console.WriteLine();
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

// Первое решение (не правильно, но интересно)
//Console.Clear();
//Console.WriteLine($"Введите 1 число: ");
//string num1 = Console.ReadLine(); // вводим сначала число в формате строки
//double number1 = Convert.ToDouble(num1);// преобразуем строку в вещественное число
//Console.WriteLine($"Введите 2 число: ");
//string num2 = Console.ReadLine();// вводим сначала число в формате строки
//double number2 = Convert.ToDouble(num2);// преобразуем строку в вещественное число
//double resault = number1 / number2;
//double num3 = resault * 10 % 10; // выводим остаток от деления, в целое число
//Console.WriteLine($"Число после деления: {resault}");
//if (num3 > 0)
//{
//    Console.WriteLine($"Число не кратно, после 0 число = {num3}");
//}
//else
//{
//    Console.WriteLine($"Число кратно");
//}

// Правильно и проще

//Console.Clear();
//Console.WriteLine($"Введите 1 число: ");
//int num1 = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine($"Введите 2 число: ");
//int num2 = Convert.ToInt32(Console.ReadLine());
//if (num1 % num2 == 0)
//    Console.WriteLine($"Число кратно ");
//else
//    Console.WriteLine($"Число не кратно, остаток = {num1 % num2} ");

// 15.67 Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно
//7 и 23.

//14 -> нет
//46 -> нет
//161 -> да

//Console.Clear();
//Console.WriteLine($"Введите число: ");
//int num = Convert.ToInt32(Console.ReadLine());
//if (num % 7 == 0 && num % 23 == 0) // && - оператор and(оба условия должны выполняться)
//{
//    Console.WriteLine($"ДА! Число делется на 7 и 23 без остатка ");
//}
//else/
//{
//    Console.WriteLine($"НЕТ! Число не делется на 7 и 23 без остатка ");
//}

// 15.68

//Напишите программу, которая принимает на вход два числа и проверяет, является ли 
//одно число квадратом другого.

//5, 25 -> да
//-4, 16 -> да
//25, 5 -> да
//8,9 -> нет

//Console.Clear();
//Console.WriteLine($"Введите число 1: ");
//int num1 = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine($"Введите число 2: ");
//int num2 = Convert.ToInt32(Console.ReadLine());
//if (num1 % num2 == 0)/
//{
//    Console.WriteLine($"{num1} является квадратом числа {num2}");
//}
//else if (num2 % num1 == 0)
//{
//    Console.WriteLine($"{num2} является квадратом числа {num1}");
//}
//else
//{
//    Console.WriteLine($"Ни одно из чисел не является квадратом другого");
//}


// 3 семинар
//Задача №17. Напишите программу, которая принимает на вход координаты точки (X и Y),
// причем X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.


//Console.Clear();
//Console.WriteLine($"Введите число нужной координаты: ");
//int x = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine($"Введите число y: ");
//int y = Convert.ToInt32(Console.ReadLine());
//if (x > 0 && y > 0)
//{
//    Console.WriteLine($"1");
//}
//else if (x < 0 && y > 0)
//{
//    Console.WriteLine($"2");
//}
//else if (x < 0 && y < 0)
//{
//    Console.WriteLine($"3");
//}
//else if (x > 0 && y < 0)
//{
//    Console.WriteLine($"4");
//}

//21. Напишите программу, которая принимает на вход координаты двух 
//точек и находит расстояние между ними в 2D пространстве.

//A (3,6); B (2,1) -> 5,09
//A (7,-5); B (1,-1) -> 7,21
//Math.Sqrt() // извлечение корня
//Math.Pow(,) // возведение в степень

//Console.Clear();
//Console.WriteLine($"Введите 1 число координаты A: ");

//double a1 = Convert.ToDouble(Console.ReadLine());
//Console.WriteLine($"Введите 2 число координаты A: ");

//double b1 = Convert.ToDouble(Console.ReadLine());
//Console.WriteLine($"Введите 1 число координаты B: ");

//double a2 = Convert.ToDouble(Console.ReadLine());
//Console.WriteLine($"Введите 2 число координаты B: ");

//double b2 = Convert.ToDouble(Console.ReadLine());

//double coordinate = Math.Sqrt(Math.Pow(a1 - a2, 2) + Math.Pow(b1 - b2, 2)); // теорема пифагора
//Console.WriteLine($"Координаты точек равны: {coordinate} ");

//22.Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел
//от 1 до N.

//5 -> 1, 4, 9, 16, 25.
//2 -> 1,4

//Console.Clear();
//Console.WriteLine($"Введите n число для таблицы квадратов: ");
//int num = Convert.ToInt32(Console.ReadLine());
//for (int i = 1; i <= num; i++)
//{
//    Console.Write($"{Math.Pow(i, 2)} ");
//}
// *Задача 13:** Напишите программу, которая выводит третью
// цифру заданного числа или сообщает, что третьей цифры нет.

// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6


//Console.Clear();
//Console.Write($"Введите число: ");
//string num = Console.ReadLine();

//if (num.Length > 2)
//{
//    Console.WriteLine($"Третья цифра = {num[2]}");
//}
//else
//{
//    Console.WriteLine($"третьей цифры нет");
//}

// второе решение задачи

//Console.Clear();
//int n = Convert.ToInt32(Console.ReadLine());
//if (n < 100)
//    Console.WriteLine("fail");

//else
//{
//    while (n > 1000)
//        n = n / 10;
//    Console.WriteLine(n % 10);
//}

// Задача 24: Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел 
//от 1 до А.
//7 -> 28
//4 -> 10
//8 -> 36

// решение с помощью цикла for
//Console.Clear();
//Console.Write($"Введите число: ");
//int n = Convert.ToInt32(Console.ReadLine());
//int summa = 0;
//for (int i = 1; i <= n; i++)
//{
//    summa = summa + i;
//}
//Console.WriteLine($"сумма чисел от 1 до {n} равна: {summa}");

// решение с помощью метода

//Console.Clear();
//Console.Write($"Введите число: ");
//double num = Convert.ToDouble(Console.ReadLine());
//double Progression(double x)
//{
//    return (1 + x) / 2 * x; // формула арифмитической прогрессии
//}
//Console.WriteLine($"сумма чисел от 1 до {num} равна: {Progression(num)} ");

// Задача 26: Напишите программу, которая принимает на вход число и 
//выдаёт количество цифр в числе.
//456 -> 3
//78 -> 2
//89126 -> 5

//Console.Clear();
//Console.Write($"Введите число: ");
//int num = Convert.ToInt32(Console.ReadLine());
//int f(int x) // подключаем метод
//{
//    int count = 0;
//    while (num > 0)
//    {
//        num = num / 10; // убираем последнюю цифру
//        count++;
//    }
//    return count; // возвращаем значение счетчика
//}
//Console.WriteLine($"Цифр в числе = {f(num)}"); //используем функцию c именем "f"

// Задача 28: Напишите программу, которая принимает на вход число N и 
//выдаёт произведение чисел от 1 до N.
//4 -> 24
//5 -> 120

//Console.Clear();
//Console.Write($"Введите число из которого нужно найти факториал: ");
//int num = Convert.ToInt32(Console.ReadLine());
//int f(int x)
//{
//    int factoryal = 1;
//    if (x == 0)
//    {
//        return 1;
//    }
//    else
//    {
//        for (int i = 1; i <= x; i++)
//        {
//            factoryal = factoryal * i;
//        }
//        return factoryal;
//    }
//}
//Console.WriteLine($"факториал равен: {f(num)}");

// Задача 30: Напишите программу, которая выводит массив из 8 элементов, заполненный 
//нулями и единицами в случайном порядке.
//[1,0,1,1,0,1,0,0]

//void InputArray(int[] array) // процедура void
//{
//    for (int i = 0; i < array.Length; i++)
//    {
//        array[i] = new Random().Next(0, 2);
//    }
//}

//Console.Clear();
//Console.Write($"Введите число из мфссив которого нужно сгенерировать: ");
//int number = Convert.ToInt32(Console.ReadLine());
//int[] array = new int[number];
//InputArray(array); // вызов метода
//Console.WriteLine($"{string.Join(", ", (array))}");

//Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2

//void InputArray(int[] array, ref int count) // процедура void
//{
//    for (int i = 0; i < array.Length; i++)
//    {
//        array[i] = new Random().Next(100, 1000);
//        if (array[i] % 2 == 0)
//        {
//            count++;
//        }
//    }
//}

//Console.Clear();
//Console.Write($"Введите число которое задаст, количество чисел в массиве: ");
//int number = Convert.ToInt32(Console.ReadLine());
//int[] array = new int[number];
//int count = 0;
//InputArray(array, ref count); // вызов метода + ссылка на счет(на массив ссылку можно не добовлять)
//Console.WriteLine($"[{string.Join(", ", (array))}] -> {count}");

//Задача 36: Задайте одномерный массив, заполненный случайными числами. 
//Найдите сумму элементов, стоящих на нечётных позициях.

//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> 0

//void InputArray(int[] array, ref int count) // процедура void
//{
//    for (int i = 0; i < array.Length; i++)
//    {
//        array[i] = new Random().Next(-100, 100);
//        if (array[i] % 2 != 0)
//        {
//            count = array[i] + count;
//        }
//    }
//}

//Console.Clear();
//Console.Write($"Введите число которое задаст, количество чисел в массиве: ");
//int number = Convert.ToInt32(Console.ReadLine());
//int[] array = new int[number];
//int count = 0;
//InputArray(array, ref count); // вызов метода + ссылка на счет(на массив ссылку можно не добовлять)
//Console.WriteLine($"[{string.Join(", ", (array))}] -> {count}");

//Задача 38: Задайте массив вещественных чисел. 
//Найдите разницу между максимальным и минимальным элементов массива.

//[3 7 22 2 78] -> 76

// void InputArray(double[] array, ref double max, ref double min) // процедура void
// {

//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i] = new Random().NextDouble() * (100 - 10) + 10; // .NextDoubl 
//                                                                 (гененрирует числа от 0 до 1) что бы сгененирировать нужный дипазон
//                                                                 нужно написать формулу .NextDoubl * (n - 10) + 10
//         if (array[i] > max)
//         {
//             max = array[i];
//         }
//     }
//     min = max;
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (array[i] < min)
//         {
//             min = array[i];
//         }
//     }
// }

// Console.Clear();
// Console.Write($"Введите число которое задаст, количество чисел в массиве: ");
// double number = Convert.ToDouble(Console.ReadLine());
// double[] array = new double[number];
// double max = 0;
// double min = 100;
// InputArray(array, ref max, ref min); // вызов метода + ссылка на счет(на массив ссылку можно не добовлять)
// Console.WriteLine($"[{string.Join(" ", (array))}] -> {max - min}");

// 3 лекция "методы"

//Вид 1 (ни чего не принимают)
//void Method1()
//{
//    Console.WriteLine("Автор метода"); // тело метода
//}
//Method1(); // вызов метода

// Вид 2(ни чего нее возвращают, но принимают)
//void Method2(string msq)
//{
//    Console.WriteLine(msq);
//}
//Method2(msq: "Текст сообщения");// вызов метода + 
//расшифровка аргумета через (:) (нужно когда несколько аргументов)
//Console.Clear();
//void Method21(string msq, int count)
//{
//    int i = 0;
//    while (i < count)
//    {
//        Console.WriteLine(msq);
//        i++;
//    }
//}
// Method21(msq: "Текст сообщения", count: 4);

// Вид 3 
//int Method3()
//{
//    return DateTime.Now.Year; // return возвращает полученое значение и прерывает метод
//}

//int year = Method3();
//Console.WriteLine(year);

// Вид 4
//string Method4(int count, string text)
//{
//    int i = 0;
//    string result = String.Empty; // присваеваем значение пустой строки (более правильно)/ вместо "" 
//    // for (int i = 0; i < count; i++) // цикл
//    while (i < count)
//    {
//        result = result + text;
//        i++;
//    }
//    return result;
//}

//string res = Method4(10, "z");
//Console.WriteLine(res);

//Console.Clear();
//for (int i = 2; i <= 10; i++)
//{
//    for (int s = 1; s <= 10; s++)
//    {
//        Console.Write($"{i} x {s} = {i * s}; ");
//    }
//    Console.WriteLine(" ");
//}

// ==== Работа с текстом 
// Дан текст. В тексте нужно все пробелы заменить черточкамиб 
// маленькие буквы "к" заменить большими "К", 
// а большие "С" заменить маленькими "с".

//string TextIndex(string text, char oldValue, char newValue)
//{
//    string newText = String.Empty;

//    for (int i = 0; i < text.Length; i++)
//    {

//        if (text[i] == oldValue)
//        {
//            newText = newText + newValue;
//        }
//        else
//        {
//            newText = newText + text[i];
//        }
//    }
//    return newText;
//}


//string text = "- Я думаю, - сказал князь, улыбаясь, - что, "
//            + "ежели бы вас послали вместо нашего милого Винценгероде,"
//            + "вы бы взяли приступом согласие прусского короля. "
//            + "Вы так красноречивы. Вы дадите мне чаю?";

//string newText = TextIndex(text, ' ', '|'); // первый раз меняем текс (при char используем одинарные кавычки)
//string newText1 = TextIndex(newText, 'к', 'К'); // второй раз меняем
//string newText2 = TextIndex(newText1, 'с', 'С'); // третий раз меняем
//Console.WriteLine(newText2);

// упорядочивание массива
//Console.Clear();
//void PrintArry(int[] arr) // используем массив в методе void
//{
//    int count = arr.Length; // присваеваем переменой count количество элементов в массиве
//    for (int i = 0; i < count; i++)
//    {
//        for (int j = i + 1; j < count; j++)
//        {
//            if (arr[i] >= arr[j])
//            {
//                int tempery = arr[i]; // используем промежуточную переменную для присваевания
//                arr[i] = arr[j];
//                arr[j] = tempery;
//            }
//        }
//    }
//    for (int i = 0; i < arr.Length; i++)
//    {
//        Console.Write($"{arr[i]} ");
//    }
//}


//int[] arr = { 2, 5, 3, 4, 5, 1, 6, 14, 10, 4, 3 };
//PrintArry(arr);

// семинар 

//  Задача 31: Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. 
//  Найдите сумму отрицательных и положительных элементов массива.
//  Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел равна 29, 
//  сумма отрицательных равна -20.

//Console.Clear(); // очищаем консоль
//void SumArray(int[] array) // процедура которая принимает массив
//{
//    int positiveNum = 0; // положительные числа
//    int negativeNum = 0; // отрицательные числа
//    for (int i = 0; i < array.Length; i++) //
//    {
//        array[i] = new Random().Next(-9, 10);// генерируем случайные числа, и добавляем в массив
//        // печатаем каждое полученное число
//        if (array[i] > 0)//
//        {
//            positiveNum = array[i] + positiveNum;//
//        }
//        else
//        {
//            negativeNum = array[i] + negativeNum;//
//        }
//    }
//    Console.WriteLine();
//    Console.Write($"[{string.Join(", ", array)}]"); // выводим массив через .Join
//    Console.WriteLine($"Сумма положительных чисел {positiveNum}");
//    Console.WriteLine($"Сумма отрицательных чисел {negativeNum}");

//}
//Console.Write($"Введите количество чисел в массиве: ");
//int n = Convert.ToInt32(Console.ReadLine());
//int[] arrey = new int[n]; // пустой массив с n числами
//SumArray(arrey);

// Задача 32: Напишите программу замена элементов массива:
// положительные элементы замените на соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2]

// Console.Clear(); // очищаем консоль
// void SumArray(int[] array) // процедура которая принимает массив
// {
//     for (int i = 0; i < array.Length; i++) //
//     {
//         array[i] = new Random().Next(-9, 10);// генерируем случайные числа, и добавляем в массив
//         Console.Write($"{array[i]} "); // показываем изначальный массив
//         array[i] = array[i] * -1; // умножаем на -1 для смены знака +/-
//     }
//     Console.WriteLine();
//     Console.Write($"[{string.Join(", ", array)}]"); // выводим массив через .Join
// }
// Console.Write($"Введите количество чисел в массиве: ");
// int n = Convert.ToInt32(Console.ReadLine());
// int[] arrey = new int[n]; // пустой массив с n числами
// SumArray(arrey);



// Задача 33: Задайте массив.Напишите программу, которая определяет,
// присутствует ли заданное число в массиве.
// 4; массив[6, 7, 19, 345, 3]->нет
// - 3; массив[6, 7, 19, 345, -3]->да

// Console.Clear();

// void SumArray(int[] array, int num) // процедура которая принимает массив
// {
//     int count = 0;
//     for (int i = 0; i < array.Length; i++) //
//     {
//         array[i] = new Random().Next(-9, 10);// генерируем случайные числа, и добавляем в массив
//         if (array[i] == num)
//         {
//             count++;
//         }
//     }
//     if (count > 0)
//     {
//         Console.WriteLine($"Да,такое число есть, и повторяется столько раз: {count} ");
//     }
//     else
//     {
//         Console.WriteLine("нет, такого числа нет");
//     }
//     Console.WriteLine();
//     Console.WriteLine($"[{string.Join(", ", array)}]"); // выводим массив через .Join
// }

// Console.Write($"Введите количество чисел в массиве: ");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.Write($"Введите число которое хотите найти от -9 до 9: ");
// int num = Convert.ToInt32(Console.ReadLine());
// int[] arrey = new int[n]; // пустой массив с n числами
// SumArray(arrey, num);

// Задача со звездочкой*

// Задана последовательность натуральных чисел, завершающаяся числом 0. 
// Требуется определить значение второго по величине элемента в этой последовательности, 
// то есть элемента, который будет наибольшим, если из последовательности удалить наибольший элемент.

// Входной файл INPUT.TXT содержит последовательность неотрицательных целых чисел, не превышающих 
// значения 100. Гарантируется, что во входных данных не более 100 чисел и 
// среди них есть хотя бы одно число 0, 
// перед которым идет как минимум 2 элемента.

// Console.Clear();

// void SumArray(int[] array) // процедура которая принимает массив
// {
//     int length = array.Length;
//     if (length < 3) array = new int[3];
//     if (length > 100) array = new int[100];
//     int maxNum = 0;
//     int maxNum2 = 0;
//     for (int i = 0; i < array.Length; i++) //
//     {
//         array[i] = new Random().Next(0, 11);// генерируем случайные числа, и добавляем в массив
//         if (maxNum < array[i]) maxNum = array[i]; // условия if пишу в одной строке
//     }
//     if (array[array.Length - 1] != 0 || array[array.Length - 1] != 10)
//     {
//         array[array.Length - 1] = 0;
//     }
//     for (int j = 0; j < array.Length; j++)
//     {
//         if (maxNum2 < array[j] && maxNum > array[j]) maxNum2 = array[j];
//     }
//     Console.WriteLine();
//     Console.WriteLine($"[{string.Join(", ", array)}]"); // выводим массив через .Join
//     Console.WriteLine($"Второе максимальное число равно: {maxNum2}");
// }

// Console.Write($"Введите количество чисел в массиве: ");
// int n = Convert.ToInt32(Console.ReadLine());
// int[] arrey = new int[n]; // пустой массив с n числами
// SumArray(arrey);

//Задача 35: Задайте одномерный массив из 123 случайных чисел. 
//Найдите количество элементов массива, значения которых лежат в отрезке [10,99].
//Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
//[5, 18, 123, 6, 2] -> 1
//[1, 2, 3, 6, 2] -> 0
//[10, 11, 12, 13, 14] -> 5

// Console.Clear();

// void SumArray(int[] array) // процедура которая принимает массив
// {
//     int count = 0;
//     for (int i = 0; i < array.Length; i++) //
//     {
//         array[i] = new Random().Next(0, 124);// генерируем случайные числа, и добавляем в массив
//         if (array[i] > 10 && array[i] < 100) count++; // условия if пишу в одной строке
//     }
//     Console.WriteLine();
//     Console.WriteLine($"[{string.Join(", ", array)}]"); // выводим массив через .Join
//     Console.WriteLine($"количество элементов массива, значения которых лежат в отрезке [10,99]: {count}");
// }

// Console.Write($"Введите количество чисел в массиве: ");
// int n = Convert.ToInt32(Console.ReadLine());
// int[] arrey = new int[n]; // пустой массив с n числами
// SumArray(arrey);

// Задача 37: Найдите произведение пар чисел в одномерном массиве. 
// Парой считаем первый и последний элемент, второй и предпоследний и т.д. 
// Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21

// void MultiArray(int[] x)
// {
//     int resault = 0;
//     int[] y = new int[resault];
//     if (x.Length % 2 == 0)
//     {
//         resault = x.Length / 2;
//         y = new int[resault];
//     }
//     else
//     {
//         resault = x.Length / 2;
//         y = new int[resault + 1];
//     }
//     for (int c = 0; c < x.Length; c++)
//     {
//         x[c] = new Random().Next(1, 10);
//     }

//     for (int i = 0, j = x.Length - 1; i <= resault; i++, j--)
//     {
//         y[i] = x[i] * x[j];
//     }
//     Console.WriteLine($"[{string.Join(", ", x)}]");
//     Console.WriteLine($"[{string.Join(", ", y)}]");
// }
// Console.Write($"Введите количество чисел в массиве: ");
// int n = Convert.ToInt32(Console.ReadLine());
// int[] arrey = new int[n]; // пустой массив с n числами
// MultiArray(arrey);

// Console.Clear();
// int[] array = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
// // Console.ReadLine() - вводим данные
// // .Split(" ") - проверяет есть ли разделитель между элементами
// // .Select(x => int.Parse(x)) - преобразует элемент строки к int
// //( так же можно производить какое либо действие) Например .Select(x => x + 5) 
// //(можно добавить после 1 .Select)
// // .ToArray(); - преобразует в массив
// Console.WriteLine($"[{string.Join(", ", array)}]");

// foreach (int elem in array)
//     // foreach() - выводит все элементы массива по очереди, как будто обращается к индексу
//     Console.Write($"{elem} ");

// Задача 39: Напишите программу, которая перевернёт одномерный массив 
//(последний элемент будет на первом месте, а первый - на последнем и т.д.)
//[1 2 3 4 5] -> [5 4 3 2 1]
//[6 7 3 6] -> [6 3 7 6]

// Console.Clear();
// void Mirror(int[] arrya)
// {
//     for (int i = 0; i < arrya.Length; i++)
//     {
//         arrya[i] = new Random().Next(1, 100);
//     }
//     Console.WriteLine($"[{string.Join(", ", arrya)}]"); // до изменений
//     for (int x = 0, j = arrya.Length - 1; x < arrya.Length / 2; x++, j--)
//     {
//         int count = arrya[x];
//         arrya[x] = arrya[j];
//         arrya[j] = count;
//     }
//     Console.WriteLine($"[{string.Join(", ", arrya)}]");
// }

// Console.Write($"Введите количество чисел в массиве: ");
// int n = Convert.ToInt32(Console.ReadLine());
// int[] arrey = new int[n]; // пустой массив с n числами
// Mirror(arrey);


//Задача 40: Напишите программу, которая принимает на вход три числа и проверяет, 
//может ли существовать треугольник с сторонами такой длины.

// Console.Clear();
// void Triangle(int[] arrya)
// {
//     for (int i = 0; i < 3; i++)
//     {
//         arrya[i] = new Random().Next(1, 100);
//     }
//     Console.WriteLine($"[{string.Join(", ", arrya)}]"); // до изменений
//     if (arrya[1] < arrya[0] + arrya[2] &&
//         arrya[0] < arrya[1] + arrya[2] &&
//         arrya[2] < arrya[0] + arrya[1])
//         Console.WriteLine($"Да, такой треугольник возможен");
//     else
//         Console.WriteLine($"НЕТ, такой треугольник не возможен");
// }
// int[] arrey = new int[3]; // пустой массив с 3 числами
// Triangle(arrey);

//Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное.

// Console.Clear();
// void Binary(int num)
// {
//     int count = 0;
//     int num1 = num;
//     while (num >= 2) // первый цикл поиск количества цифр в массиве
//     {
//         int number = num % 2;
//         num = num / 2;
//         count++;
//         Console.Write($"{num} ");
//     }
//     int[] arrey = new int[count + 1];   // задаем количество цифр в массиве + 1, 
//                                         //так как первая цифрав двоичной системе считается отдельно
//     int index = count;
//     while (num1 >= 2)
//     {
//         int number = num1 % 2;
//         num1 = num1 / 2;
//         arrey[index] = number;
//         index--;
//     }
//     arrey[0] = num1; // задаем 1 цифру в двоичной системе
//     Console.WriteLine();
//     Console.WriteLine($"{string.Join("", arrey)}");
// }
// Console.Write($"Введите число которое хотите преобразовать в двоичную систему: ");
// int num = Convert.ToInt32(Console.ReadLine());
// Binary(num);

// второй способ получения двоичного числа

// Console.Clear();
// Console.Write("Введите число: ");
// int n = Convert.ToInt32(Console.ReadLine());

// string res = String.Empty; // пустая строка
// while (n > 0)
// {
//     res = Convert.ToString(n % 2) + res;    // добавляем в пустую строку(так как res в 
//                                             //конца результат зеркален) если хотим сначала
//                                             // не зеркально то можно написать +=
//     n /= 2; // счетчик
// }
// Console.WriteLine(res);

//Задача 45: Напишите программу, 
//которая будет создавать копию заданного массива с помощью поэлементного копирования.

// Console.Clear();
// void Mirror(int[] arrya, int[] arreyB) // добавляем 2 массива из одного будем копировать в другой
// {
//     for (int i = 0; i < arrya.Length; i++)
//     {
//         arrya[i] = new Random().Next(1, 100); // генерируем случайные числа от 1 до 99 для 1 массива
//     } // вместо гениратора можем сами ввести изначально цифры например: {1, 2, 3, 4}
//     Console.WriteLine($"[{string.Join(", ", arrya)}]"); // до изменений вывод
//     for (int x = 0; x < arrya.Length; x++)
//     {
//         arreyB[x] = arrya[x]; // из первого по индексу копируем элемент во второй массив
//     }
//     Console.WriteLine($"[{string.Join(", ", arreyB)}]"); //копия вывода результата
// }

// Console.Write($"Введите количество чисел в массиве: ");
// int n = Convert.ToInt32(Console.ReadLine());
// int[] arreyA = new int[n]; // пустой массив с n числами
// int[] arreyB = new int[n];
// Mirror(arreyA, arreyB);

// arreyA[0] = -5; // изменяем 1 элемент для проверки
// Console.WriteLine($"Вывод после изменений ");
// Console.WriteLine($"[{string.Join(", ", arreyA)}]");
// Console.WriteLine($"[{string.Join(", ", arreyB)}]");

// Лекция 4 .. Двухмерные массивы и рекурсия
Console.Clear();

// string[,] table = new string[2, 3]; // создание 2-х мерного массива , 
//                                     //- запятая нужна для того что бы интарпритатор понял что тут 2 - х мерный массив
//                                     // [2, 3] - 2 - две строки, 3 - три столбца
// table[1, 2] = "слово"; // указываем индекс через [] где 1 - это 0 элемент - 2  столбца

// for (int rows = 0; rows < 2; rows++)
// {
//     for (int columns = 0; columns < 3; columns++)
//     {
//         Console.WriteLine($"|_{table[rows, columns]}_|");
//     }
// }

int[,] matrix = new int[3, 4];

for (int rows = 0; rows < matrix.GetLength(0); rows++) // matrix.GetLength(0) - обращается к строкам (3)
{
    for (int columns = 0; columns < matrix.GetLength(1); columns++) //GetLength(1) - обращается к столбцам (4)
    {
        Console.Write($"_|_{matrix[rows, columns]}_|_"); // для вывода первой строки 1-4 столбца
    }
    Console.WriteLine(); // пробел для красивого вывода 2 строка и так далее
}
