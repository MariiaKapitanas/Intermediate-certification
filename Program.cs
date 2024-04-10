class Program
{
static void Main(string[] args)
{
    string[] inputArray = { "Good", "Hello", ",./", "77" };
    int count = 0;
    foreach (string str in inputArray)
    {
        if (str.Length <= 3)
            count++;
    }

    string[] filteredArray = new string[count];
    int index = 0;
    foreach (string str in inputArray)
    {
        if (str.Length <= 3)
        {
            filteredArray[index] = str;
            index++;
        }
    }

    Console.WriteLine("Отфильтрованный массив строк:");
    foreach (string str in filteredArray)
    {
        Console.WriteLine(str);
    }
}
}