// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int InputNumberA(string text)
{
    Console.WriteLine(text);
    int a = Convert.ToInt32(Console.ReadLine());
    return a;
}

int InputNumberB(string text)
{
    Console.WriteLine(text);
    int b = Convert.ToInt32(Console.ReadLine());
    return b;
}

int NumberPower(int a, int b)
{
    int numberPower = 1;
    for(int i = 1; i <= b; i++)
        numberPower = numberPower * a;
    return numberPower;
}

int a = InputNumberA("Введите число А ");
int b = InputNumberB("Введите число В ");
int numberPower = NumberPower(a, b);
Console.WriteLine($"Число {a} в степени {b} равно {numberPower}.");