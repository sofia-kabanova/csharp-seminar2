// Задача 13: Напишите программу, которая 
// выводит третью цифру заданного числа 
// или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6
Console.Clear();
Console.Write("Введите число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
if(num1<100) Console.WriteLine($"В числе {num1} третий цифры нет");
else 
{
    int num2=num1;
    while (num2>999)
    {
        num2 = num2 / 10;
    }
    num2 = num2-(num2 - (num2%10));
 Console.WriteLine($"В числе {num1} третья цифра {num2}");
}