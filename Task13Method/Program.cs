/// Задача 13: Напишите программу, которая 
// выводит третью цифру заданного числа 
// или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6
Console.Clear();
Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
int Third (int n)
    {
    while (n>999) n = n / 10; 
    return n;
    } 
if(num<100) Console.WriteLine($"В числе {num} третий цифры нет");
else
{
   int result = Third(num);
   Console.WriteLine($"В числе {num} третья цифра {num};третья цифра {result % 10}");
}
