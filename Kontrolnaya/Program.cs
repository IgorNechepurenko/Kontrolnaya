string[] a = new string[5] {"1234", "1567", "-2", "computer", "11"};
string[] b = new string[a.Length];
void f(string[] a, string[] b)
{
    int count = 0;
    for (int i = 0; i < a.Length; i++)
    {
    if(a[i].Length <= 3)
        {
        b[count] = a[i];
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
f(a, b);
PrintArray(b);

