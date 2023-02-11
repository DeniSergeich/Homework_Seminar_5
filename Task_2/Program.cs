//Найдите произведение пар чисел в одномерном массиве.
//Парой считаем первый и последний элемент, второй и предпоследний и т.д.
//Результат запишите в новом массиве.
Console.Clear();
Console.Write("Введите количество элементов массива: ");
int numbersOfArray = int.Parse(Console.ReadLine());
Console.Write("Введите диапазон элементов массива через пробел: ");
string range = Console.ReadLine();
int[] array = GetArray(numbersOfArray, range);
int[] arrayResult = Result(array);
Console.WriteLine($"Изначальный массив: [{String.Join(", ", array)}]");
Console.WriteLine($"После преобразования: [{String.Join(", ", arrayResult)}]");
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
int[] Result(int[] array)
{
    int a = 0;
    if (array.Length % 2 == 0) // Определяется количесво элементов нового массива
    {
        a = array.Length / 2; // Если количество элементов исходного массива четное, длина нового будет равна дилина исходного пополам
    }
    else
    {
        a = array.Length / 2 + 1; // Если количество элементов исходного массива нечетное, длина нового будет равна длина исходного пополам + 1 элемент
    }
    int[] result = new int[a]; // Создается новый массив с учетом длины исходного
    for (int i = 0; i < array.Length / 2; i++) 
    {
        if (array.Length % 2 != 0) result[array.Length / 2] = array[array.Length / 2]; // Если длина исходного массива нечетная, 
                                                                                        //средний элемент записывается на последнюю позицию нового массива
        result[i] = array[i] * array[(array.Length - 1) - i]; // Заполняются элементы нового массива произведением крайних
    }
    return result;
}