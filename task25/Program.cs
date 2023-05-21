// Задача 25: Напишите программу, который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16


int number1 = Prompt("Введите первое число: ");
int number2 = Prompt("Введите второе число: ");
Console.WriteLine($"число {number1} в натуральной степени {number2} равна {GetDegreeNumber(number1, number2)}");

int Prompt(string message)
{
    System.Console.Write(message);
    string value = Console.ReadLine()!;
    int result = Convert.ToInt32(value);
    return result;
}

int GetDegreeNumber(int num1, int num2)
{
    int numdegree = num1;
    for (int i = 2; i <= num2; i++)
    {
        numdegree *= num1;
    }
    return numdegree;
}