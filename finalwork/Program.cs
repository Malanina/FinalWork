// Итоговая проверочная работа.
// Задача: Написать программу, которая из имеющегося массива строк формирует
// новый массив из строк, длина которых меньше, либо равна 3 символам.
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте
// выполнения алгоритма. При решении не рекомендуется пользоваться
// коллекциями, лучше обойтись исключительно массивами.

// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []

Console.Clear();
string[] stringArray1 = new string[] {"Hello", "2", "world", ":-)"};
string[] stringArray2 = new string[stringArray1.Length];

void CreateArray2(string[] stringArray1, string[] stringArray2)
{
    int count = 0;
    for (int i = 1; i < stringArray1.Length; i++)
    {
        if (stringArray1[i].Length <= 3)
        {
            stringArray2[count] = stringArray1[i];
            count++;
        }
    }
}


