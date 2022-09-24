//Задача 10: Напишите программу, которая
// принимает на вход трёхзначное число 
// на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1
Console.Clear();
Console.Write("Введите трехзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number < 99 || number > 999) Console.WriteLine($"{number} не является трехpначным числом, введите трехзначное число");
else
{
    int Digit(int num)
    {
        int firstDigit = num / 10 % 10;
        return firstDigit;
    }
int result = Digit(number);
Console.WriteLine($"{number} -> {result}");
}