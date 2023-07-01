//Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, 
//длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, 
//либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, 
//лучше обойтись исключительно массивами.

// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []

using System;
using static System.Console;
Clear();
WriteLine("Введите что-нибудь через пробел: ");
string elements = ReadLine();
string[] baseArray = GetArrayFromString(elements);
string[] GetArrayFromString(string stringArray)
{
    string[] nums = stringArray.Split(" ", StringSplitOptions.RemoveEmptyEntries);
    string[] res = new string[nums.Length];

    for (int i = 0; i < nums.Length; i++)
    {
        res[i] = nums[i];
    }
    return res;
}
int GetNumber(string[] arr)
{
    int A = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length <= 3)
        {
            A++;
        }
    }
    return A;
}
int B = GetNumber(baseArray);
string[] GetNewArray(string[] arr)
{
    string[] res = new string[B];
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length <= 3)
        {
            res[count] = arr[i];
            count++;
        }
    }
    return res;
}
WriteLine();
WriteLine($"[{String.Join(", ", baseArray)}] -> [{String.Join(", ", GetNewArray(baseArray))}]");
WriteLine();