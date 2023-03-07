// Вывод через консоль приветствие Console - обращение к консоле; 
//.WriteLin - команда для печати на экран
//Console.WriteLine("Hello, World!"); 

// Просьба ввести данные у пользователя и поприветствовать его
Console.WriteLine("Введите Ваше имя");
// string - тип данных (строка) добавляется перед переменной
string username = Console.ReadLine();
// username - имя пользователя; Console - обращение к консоле; .Readline - команда для ввода данных
Console.WriteLine("Привет, "); // выводит - Привет, 
Console.WriteLine(username); // выводит содержание переменной username