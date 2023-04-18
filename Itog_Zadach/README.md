# ИТОГОВАЯ ЗАДАЧА
## **Задача**: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

## Примеры:
* ### [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
* ### [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
* ### [“Russia”, “Denmark”, “Kazan”] → []
```mermaid
flowchart TD
    A["num = int(input())
    string[] array = new string[num]" ] 
    --> B{"CreatStringArray, i = 0 
    array.Length > i"}
    B --> |YES| C["array[i] = input()"]
    B --> |NO| D["array[], num
    int count = 0;
    int j = 0;"]
    C -->|i++| B
    D --> E{"i = 0; i < num"}
    E -->|Yes| F["array[i].Length < 4"]
    F -->|Yes, i++, count++ | G["count++"]
    G -->|i++| E
    F --> |"NO, i++"| E
    E --> |NO| H["string[] arrayNew = new string[count];"]
    H --> J{"w = 0; w < num"}
```



