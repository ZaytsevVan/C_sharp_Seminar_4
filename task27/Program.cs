// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int InputNumber(string text)
{
    Console.WriteLine(text);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

int Sum(int number)
{
    int a = 0;
    int sum = 0;
    while(number > 0)
    {
        a = number % 10;
        sum = sum + a;
        number = number / 10; 
    }
    return sum;
}

int number = InputNumber("Введите число ");
int sum = Sum(number);
Console.WriteLine($"Сумма всех цифр в числе равна {sum}");