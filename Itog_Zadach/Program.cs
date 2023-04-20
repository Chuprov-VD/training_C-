void CreatStringArray(string[] array, int num)
{
    for (int i = 0; i < num; i++)
    {
        Console.WriteLine("Введите любое слово");
        array[i] = Console.ReadLine();
    }
}

void CheckStringArray(string[] array, int num)
{
    int j = 0;
    int count = 0;
    for (int w = 0; w < num; w++)
    {
        if (array[w].Length < 4)
        {
            count++;
        }
    }
    string[] arrayNew = new string[count];
    for (int i = 0; i < num; i++)
    {
        if (array[i].Length < 4)
        {
            arrayNew[j] = array[i];
            j++;
        }
    }
    Console.WriteLine($"[{string.Join(", ", array)}] -> [{string.Join(", ", arrayNew)}]");
}


Console.Clear();
Console.WriteLine("Введите количество слов в массиве");
int num = Convert.ToInt32(Console.ReadLine());
string[] array = new string[num];
CreatStringArray(array, num);
CheckStringArray(array, num);