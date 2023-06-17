// Задача 1: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа
Console.Write("Введите трёхзначное число: ");
int num = Convert.ToInt32(Console.ReadLine());

for (int ii = 1; ii < 3 && (num <= 100 | num > 999); ii++)
{
    Console.Write(ii + "Это не трёхзначное число, попробуйте ещё раз: ");
    num = Convert.ToInt32(Console.ReadLine());
}

num = num / 10 % 10;
Console.WriteLine($"Вторая цифра введённого числа: {num}"); 