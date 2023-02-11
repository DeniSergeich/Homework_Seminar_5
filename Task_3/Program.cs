Console.Clear();
int[] array = GetArray();
PrintResult();
int[] GetArray()
{    //Создание рандомного массива трехзначных чисел
    int a = new Random().Next(3, 50);
    int[] result = new int[a];
    for (int i = 0; i < result.Length; i++)
    {
        result[i] = new Random().Next(100, 1000);
    }
    return result;
}
int Sum(int[] array)
{    // Подсчет четных элементов массива
    int sum = 0;
    foreach (int item in array)
    {
        if (item % 2 == 0) sum += 1;
    }
    return sum;
}
void PrintResult()
{
    Console.WriteLine($"Количество четных элементов в массиве: {Sum(array)}");
    Console.Write($"[{String.Join(", ", array)}]");
}