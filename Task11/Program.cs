// Напишите программу, которая выводит 
// случайное трехзначное число
// удаляет вторую цифру этого числа
// 765 -> 46
// 782 -> 82
// 918 -> 98

int number = new Random().Next(100,1000);
int Digit(int num)
{
    int firstDigit = num / 100 * 10; 
    int secondDigit = num % 10;
    return firstDigit + secondDigit;
}
int result = Digit(number);
Console.WriteLine($"{number} -> {result}");