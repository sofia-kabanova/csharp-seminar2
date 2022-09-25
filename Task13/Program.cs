// Задача 13: Напишите программу, которая 
// выводит третью цифру заданного числа 
// или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6
Console.Clear();
Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
if(num<100) Console.WriteLine($"В числе {num} третий цифры нет");
else 
{
    int num1=num;
    while (num1>999) num1 = num1 / 10;
 Console.WriteLine($"В числе {num} третья цифра {num1%10}");
}