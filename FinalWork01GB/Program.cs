

static string[] GetArrayFromConsole()
{
    Console.Write("Введите слова через пробел: ");

    string input = Console.ReadLine()!;
    string[] inputArray = input.Split(' ');
    
    return inputArray;
}

static string[] FilterArrayLessNLetters(string[] array, int n)
{
    int count = 0;
    foreach (string word in array)
    {
        if (word.Length < n) count++;
    }

    string[] resultArray = new string[count];
    
    count = 0;
    foreach (string word in array)
    {
        if (word.Length < n)
        {
            resultArray[count] = word;
            count++;
        }
    }

    return resultArray;
}

static void PrintArray(string[] array)
{
    Console.WriteLine($" [ {String.Join(", ", array)} ] ");
}

int lessThan = 4;

string[] array = GetArrayFromConsole();
Console.WriteLine("Введенный массив:");
PrintArray(array);


string[] filteredArray = FilterArrayLessNLetters(array, lessThan);
Console.WriteLine("Результат:");
PrintArray(filteredArray);