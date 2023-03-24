﻿int InputInt32(string message) //приглашение ввода с клавиатуры целого числа
{
    System.Console.Write(($"{message}: "));
    int value;
    bool isCorrectInt32 = int.TryParse(Console.ReadLine(), out value);
    if (isCorrectInt32)
    {
        return value;
    }
    System.Console.WriteLine("You entered not a number");
    Environment.Exit(-1);
    return 0;
}
string[] InputStringArrayConsole(int Size) 
{
    string[] array = new string[Size];
    for (int i = 0; i < Size; i++)
    {
        System.Console.Write("Enter array element: ");
        array[i] = Console.ReadLine();
    }
    return array;
}