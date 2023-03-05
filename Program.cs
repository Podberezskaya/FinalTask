string[] f_array = {"hello", "world", "123", "new", "5447"};
string[] s_array = new string[f_array.Length];
void SecondArray(string[] f_array, string[] s_array)
{
    int count = 0;
    for (int i = 0; i < f_array.Length; i++)
    {
    if(f_array[i].Length <= 3)
        {
        s_array[count] = f_array[i];
        count++;
        }
    }
}
void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
SecondArray(f_array, s_array);
PrintArray(s_array);
