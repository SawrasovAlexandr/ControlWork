// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. 
//         Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться
//         коллекциями, лучше обойтись исключительно массивами.

// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []

Console.WriteLine("Введите массив строк через пробел: ");
string[] strRandomLength = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
string strTemp = String.Empty;
for (int i = 0; i < strRandomLength.Length; i++)
{
    if (strRandomLength[i].Length <= 3)
    {
        strTemp += strRandomLength[i] + " "; 
    }
}
string[] str3Length = strTemp.Split(" ", StringSplitOptions.RemoveEmptyEntries);
Console.WriteLine($"[{String.Join(", ", str3Length)}] ");