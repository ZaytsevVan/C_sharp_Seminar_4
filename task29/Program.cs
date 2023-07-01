// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

int LeftBorder(string text)
{
    Console.WriteLine(text);
    int leftBorder = Convert.ToInt32(Console.ReadLine());
    return leftBorder;
}

int RightBorder(string text)
{
    Console.WriteLine(text);
    int rightBorder = Convert.ToInt32(Console.ReadLine());
    return rightBorder;
}

int[] Array(int[] array)
{
    Random rand = new Random();
    int leftBorder = LeftBorder("Введите минимальное значение элемента массива ");
    int rightBorder = RightBorder("Введите максимальное значение элемента массива ");
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = rand.Next (leftBorder, rightBorder);
    }
    return array;
}

void PrintArray(int[] array)
{
    Console.WriteLine($"[{string.Join(",", array)}]");
}

int[] array = new int[8];
array = Array(array);
PrintArray(array);
