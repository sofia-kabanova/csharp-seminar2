//Задача 15: Напишите программу, которая
// принимает на вход цифру, обозначающую день недели, 
// и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет
Console.Clear();
Console.Write("Введите цифру, обозначающую день недели: ");
int day = Convert.ToInt32(Console.ReadLine());
if (day >0 && day < 8 )
{
bool Multiply(int num)// создали метод, ввели параметры num1 и num2
 // тип данных bool, логический тип, возвращает true или false
{
    return num == 6 || num == 7; // метод проверяет остаток от деления 
    // возвращает лоибо true либо false
}
bool result = Multiply(day); 
// вызываем (запускаем) метод для проверки введеных чисел 
// в переменную  result записывается  true  или false
if(result) Console.WriteLine($"{day} - выходной");
 // если true
else Console.WriteLine($"{day} - не выходной");
//  если false
}
else Console.WriteLine($"{day} - нет такого дня недели");