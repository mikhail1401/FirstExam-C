// Задача: Написать программу, которая из имеющегося массива строк 
// формирует новый массив из строк, длина которых меньше, либо равна 3 символам. 
// Первоначальный массив можно ввести с клавиатуры, 
// либо задать на старте выполнения алгоритма. 
// При решении не рекомендуется пользоваться коллекциями, 
// лучше обойтись исключительно массивами.

// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []

Console.WriteLine("Enter some array of stings devided by space: ");
string input = Console.ReadLine();

string[] ConvertToArray(string text)
{
    string[] arrayFromText = text.Split(" ");
    return arrayFromText;
}

void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
    Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

string[] ModifyArray(string[] originalArray)
{
    string[] modifiedArray = new string[new Random().Next(0, 4)];
    for (int i=0; i<modifiedArray.Length; i++)
    {
        modifiedArray[i] = originalArray[new Random().Next(originalArray.Length)];
    }
    return modifiedArray;
}

Console.WriteLine("Initial Array: ");
string[] initialArray = ConvertToArray(input);
PrintArray(initialArray);
Console.WriteLine("Modifed Array: ");
string[] modifiedArray = ModifyArray(initialArray);
PrintArray(modifiedArray);