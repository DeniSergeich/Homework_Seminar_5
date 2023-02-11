Console.Clear();
Console.Write("Введите количество элементов массива: ");
int numbersOfArray = int.Parse(Console.ReadLine());
Console.Write("Введите диапазон элементов массива через пробел: ");
string range = Console.ReadLine();
int[] array = GetArray(numbersOfArray, range);
Console.WriteLine($"Количество элементов массива лежащих в промежутке от 10 до 99 равно: {Result(array, 10, 99)}");
Console.Write($"[{String.Join(", ", array)}]");
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
int Result(int[] array, int minRange, int maxRange)
{
    int count = 0;
    foreach (int el in array)
    {
        if(el >= minRange && el <= maxRange) count+=1;
    }
    return count;
}