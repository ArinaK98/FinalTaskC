string[] array1 = new string[5] {"123", "-2", "hello", "world", ":-)"};
string[] array2 = new string[array1.Length];
FindElements(array1, array2);
Console.WriteLine($"Массив №1: {string.Join(" ", array1)} ");
Console.WriteLine($"Массив №2 - ответ: {string.Join(" ", array2)} ");

void FindElements(string[] array1, string[] array2)
{
    int count = 0;
    for (int i = 0; i < array1.Length; i++)
    {
        if (array1[i].Length <= 3)
        {
            array2[count] = array1[i];
            count++;
        }

    }
}


