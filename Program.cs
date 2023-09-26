// Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. 
//Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 

Console.Clear();

int GetElementsNumber(string messsage, string errorMessage)
{
    while (true)
    {
        Console.Write(messsage);
        bool isCorrect = int.TryParse(Console.ReadLine(), out int elementsNumber);
        if (isCorrect && elementsNumber > 0)
            return elementsNumber;
        Console.WriteLine(errorMessage);
    }
}

string GetElement(string message)
{
    Console.Write(message);
    string element = Console.ReadLine() ?? "";
    return element;
}

void PrintArray(string[] array, string message)
{
    Console.Write($"{message}[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i == array.Length - 1)
        {
            Console.Write(array[i]);
        }
        else
            Console.Write(array[i] + ", ");
    }
    Console.WriteLine("]");
}

string[] GetFilteredArray(string[] array, int newLength)
{
    string[] newArray = new string[newLength];
    int i = 0;
    foreach(string element in array)
    {
        if (element.Length <= 3)
        {
            newArray[i] = element;
            i++;
        }
    }
    return newArray;
}

/// 
void MainPart()
{
    int eCount = GetElementsNumber("Enter Nº of elements: ", "Invalid input! Please enter a number > 0");
    string[] array = new string[eCount];
    int k = 0;
    for (int i = 0; i < eCount; i++)
    {
        string element = GetElement($"Enter {i + 1} element: ");
        array[i] = element;
        if (element.Length <= 3)
        {
            k++;
        }
    }
    PrintArray(array, "Your array: ");
    PrintArray(GetFilteredArray(array, k), "Your filtered array: ");
}

MainPart();