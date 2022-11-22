string[] inputArray = new string[11] { "hello", "2", "world", ":-)", "1234", "1567", "-2", "computer science", "Russia", "Denmark", "Kazan" };
int lengthLimit = 3;
int resultItems = CheckArray(inputArray, lengthLimit);
string[] outputArray = new string[resultItems];
int CheckArray(string[] array, int lengthLimit)
{
    int result = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= lengthLimit)
            result++;
    }
    return result;
}
void WriteNewArray(string[] oldArray, string[] newArray, int lengthLimit)
{
    int temp = 0;
    for (int i = 0; i < oldArray.Length; i++)
    {
        if (oldArray[i].Length <= lengthLimit)
        {
            newArray[temp] = oldArray[i];
            temp++;
        }
    }
}
string PrintArray(string[] array)
{
    string result = string.Empty;
    for (int i = 0; i < array.Length; i++)
    {
        result += $"{array[i]}";
        if (i < array.Length - 1)
            result += ", ";
    }
    return result;
}
WriteNewArray(inputArray, outputArray, lengthLimit);
Console.WriteLine($"{PrintArray(outputArray)}");