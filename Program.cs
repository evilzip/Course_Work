int InputInt32(string message) //приглашение ввода с клавиатуры целого числа
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
string[] InputStringArrayConsole(int Size) //Задание массива строк вводом его элементов из консоли
{
    string[] array = new string[Size];
    for (int i = 0; i < Size; i++)
    {
        System.Console.Write("Enter array element: ");
        array[i] = Console.ReadLine();
    }
    return array;
}
void PrintArray(string[] array) // Вывод массива в консоль
{
    System.Console.WriteLine("["+string.Join(", ", array)+"]");
}
int CountElementsRequiredLength(string[] array, int StringLength) //Подсчет количества элементов массива пользователя, длина которых меньше либо равна заданному количеству символов
{
    int Count =0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= StringLength) Count++;
    }
    return Count;    
}
string[] CreateArrayStringRequiredLength(string[] array, int StringLength) // создание нового массива из элементов массива пользователя, длина которых меньше либо равна заданному количеству символов
{
    int ResultLength = CountElementsRequiredLength(array, StringLength);
    string[] result = new string[ResultLength];
    int j=0;       
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= StringLength)
        {
            result[j] = array[i];
            j++;
        }
            
    }
    return result;
}
int UserArrayLength = InputInt32("Enter size of your array");
string[] UserArrayString = InputStringArrayConsole(UserArrayLength);
PrintArray(UserArrayString);
int UserStringLength = InputInt32("Enter maximum length for elements");
System.Console.Write($"New array with elements length <= {UserStringLength} : ");
PrintArray(CreateArrayStringRequiredLength(UserArrayString,UserStringLength));