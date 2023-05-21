// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11
// 82 -> 10
// 9012 -> 12


int number = Prompt("Введите число: ");

Console.WriteLine($"Сумма цифр в числе {number} равна {GetSumOfDigits(number)}");

int Prompt(string message)
{
    System.Console.Write(message);
    string value = Console.ReadLine()!;
    int result = Convert.ToInt32(value);
    return result;
}

int GetSumOfDigits(int num1)
{
    int sum = 0;
    while (num1 > 0)
    {
        sum += num1 % 10;
        num1 /= 10;
    }
    return sum;
}