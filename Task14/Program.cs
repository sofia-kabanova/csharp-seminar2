//14. Напишите программу, которая
// принимает на вход число
// проверяет кратно ли оно одновременно 7 и 23
// 14 -> нет
// 46 -> нет 
// 161 -> да 

Console.Clear();
Console.Write("Введите число: ");
int x = Convert.ToInt32(Console.ReadLine());
bool Multiply(int num)// создали метод, ввели параметр num
 // тип данных bool, логический тип, возвращает true или false
{
    return num % 7 == 0 && num % 23 == 0; // метод проверяет остаток от деления 
    // возвращает лоибо true либо false
}
bool result = Multiply(x); 
// вызываем (запускаем) метод для проверки введенного числа 
// в переменную  result записывается  true  или false
if(result) Console.WriteLine($"{x} -> да");
 // если true
else Console.WriteLine($"{x} -> нет");
//  если false