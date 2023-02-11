Console.Clear();
int[] array = GetRandomArray();
PrintResult();
int[] GetRandomArray()
{    
    int a = new Random().Next(2, 15);
    int[] result = new int[a];
    for (int i = 0; i < result.Length; i++)
    {
        result[i] = new Random().Next(1, 100);
    }
    return result;
}
int Diff(int[] array)
{    
    int diff = 0;
    int min = array[0];
    int max = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (min > array[i]) min = array[i];
        if (max < array[i]) max = array[i];
    }
    diff = max - min;
    return diff;
}
void PrintResult()
{
    Console.WriteLine($"Разница между максимальныйм и минимальным элементами массива: {Diff(array)}");
    Console.Write($"[{String.Join(", ", array)}]");
}