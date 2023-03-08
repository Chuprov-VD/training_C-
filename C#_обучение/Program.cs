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