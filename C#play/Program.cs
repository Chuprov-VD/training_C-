// Игра камень, ножницы, бумага

void Account(int num, int num1) // создание массива
{
    void PrintSameResault(int num, int num1)
    {
        Console.WriteLine("Вы выбрали с компьютером одинаково");
        Console.WriteLine("Если хотите попробовать снова введите 1, если выйти то другое число");
        num = Convert.ToInt32(Console.ReadLine());
        if (num == 1)
        {
            Console.WriteLine("Ура! Спасибо");
            Account(num, num1);
        }
    }

    void PrintVictoryResault(int num, int num1)
    {
        Console.WriteLine("Вы ПОБЕДИЛИ!");
        Console.WriteLine("Если хотите попробовать снова введите 1, если выйти то другое число");
        num = Convert.ToInt32(Console.ReadLine());
        if (num == 1)
        {
            Console.WriteLine("Ура! Спасибо");
            Console.Clear();
            Account(num, num1);
        }
    }
    void PrintDefeatResault(int num, int num1)
    {
        Console.WriteLine("Вы ПРОИГРАЛИ");
        Console.WriteLine("Если хотите попробовать снова введите 1, если выйти то другое число");
        num = Convert.ToInt32(Console.ReadLine());
        if (num == 1)
        {
            Console.WriteLine("Ура! Спасибо");
            Account(num, num1);
        }
    }

    Console.WriteLine("Введите цифру от 1 до 3. Где 1 - бумага, 2 - ножницы, 3 - камень: ");
    num = Convert.ToInt32(Console.ReadLine());
    num1 = Convert.ToInt32(new Random().Next(1, 4));

    if (num == num1)
    {
        PrintSameResault(num, num1);
    }
    if (num1 == 1 && num == 2)
    {
        Console.WriteLine("Вы выбрали ножницы, а компьютер бумагу");
        PrintVictoryResault(num, num1);

    }

    if (num1 == 3 && num == 2)
    {
        Console.WriteLine("Вы выбрали ножницы, а компьютер камень");
        PrintDefeatResault(num, num1);
    }
    if (num1 == 1 && num == 3)
    {
        Console.WriteLine("Вы выбрали камень, а компьютер бумагу");
        PrintDefeatResault(num, num1);
    }
    if (num1 == 2 && num == 3)
    {

        Console.WriteLine("Вы выбрали камень, а компьютер ножницы");
        PrintVictoryResault(num, num1);

    }
    if (num1 == 3 && num == 1)
    {

        Console.WriteLine("Вы выбрали бумагу, а компьютер камень");
        PrintVictoryResault(num, num1);

    }
    if (num1 == 2 && num == 1)
    {

        Console.WriteLine("Вы выбрали бумагу, а компьютер ножницы");
        PrintDefeatResault(num, num1);

    }
}

Console.Clear();
int num = 0;
int numOpp = 0;
//int[] size = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray(); // можно так 
//ввести данные размера матрицы
Account(num, numOpp);