Console.Clear();
Console.Write("Введите количество элементов массива: ");
int numbersOfArray = int.Parse(Console.ReadLine());
Console.Write("Введите диапазон элементов массива через пробел: ");
string range = Console.ReadLine();
int[] array = GetArray(numbersOfArray, range);
PrintResult();
int[] GetArray(int numbersOfArray, string range)
{
    int[] array = new int[numbersOfArray];
    string[] rangeNum = range.Split(" ", StringSplitOptions.RemoveEmptyEntries);
    int leftLimit = int.Parse(rangeNum[0]);
    int rightLimit = int.Parse(rangeNum[1]);
    for (int j = 0; j < array.Length; j++)
    {
        array[j] = new Random().Next(leftLimit, rightLimit + 1);
    }
    return array;
}
int GetSum(int[] array)
{
    int sum = 0;
    for (int i = 1; i < array.Length; i += 2)
    {
        sum += array[i];
    }
    return sum;
}
void PrintResult()
{
    Console.WriteLine($"Сумма элементов массива на нечетных позициях равна: {GetSum(array)}");
    Console.WriteLine($"[{String.Join(", ", array)}]");
}