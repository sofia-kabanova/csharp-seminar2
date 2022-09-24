// Напишите программу, которая 
// принимает на вход два числа 
// (1) проверяет является ли первое число квадратом второго
// (2) является ли второе квадратом перовго
// если (1) или (2 )да, то "ДА"
// если (1) или (2) нет, то "НЕТ"
// 5, 25 -> ДА
// 16, -4 -> ДА
// 8, 9 -> НЕТ 

Console.Clear();
Console.Write("Введите первое число: ");
int first = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int second= Convert.ToInt32(Console.ReadLine());
bool Multiply(int num1, int num2)// создали метод, ввели параметры num1 и num2
 // тип данных bool, логический тип, возвращает true или false
{
    return num1 / num2 == num2 || num2 / num1 == num1; // метод проверяет остаток от деления 
    // возвращает лоибо true либо false
}
bool result = Multiply(first,second); 
// вызываем (запускаем) метод для проверки введеных чисел 
// в переменную  result записывается  true  или false
if(result) Console.WriteLine($"{first}, {second} -> Yes");
 // если true
else Console.WriteLine($"{first}, {second} -> NO");
//  если false
