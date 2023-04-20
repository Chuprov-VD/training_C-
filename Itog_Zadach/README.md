# ИТОГОВАЯ ЗАДАЧА
## **Задача**: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

## Примеры:
* ### [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
* ### [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
* ### [“Russia”, “Denmark”, “Kazan”] → []
```mermaid
flowchart TD 
     A([Beginning]) --> A1 
    A1[/"num = int(input())"/] --> 
    A2["string [array] = new string[num]"] --> 
    B[["CreatStringArray 
    (array[], num)"]] 
    B --> B1{"for (i = 0;  
    i < num);  
    i++"} 
    B1 --> |YES| B2[/"array[i] = input()"/]  
    --> B1 
    B1 -->  |NO| B3(["END CreatStringArray"])
     --> C[["CheckStringArray 
    (array[], num)"]] --> 
    C1["j = 0
    count = 0"] --> 
    C2{"for (w = 0;  
    w < num);  
    w++"} -->|YES| C3{"array[i].Length < 4"} -->  
    |YES| C4[count++] --> C2; 
    C3 --> |NO|C2;
    C2 --> |NO| C5["string[] arrayNew = new string[count];"]  
    --> D{"for (i = 0;  i < num);  
    i++"} --> |YES| D1{"array[i].Length < 4"} --> D2["arrayNew[j] = 
    array[i]; j++;"] --> D
    D --> |NO|D5[Print array, arrayNew] --> D6(["END"]);
```



