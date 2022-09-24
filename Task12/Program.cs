// Напишите программу, которая 
// принимает на вход два числа 
// проверяет является ли перове число кратно второму
// если да, то "кратно"
// если нет, то "не кратно" и выводит остаток
// 34, 5 -> не кратно, остаток 4
// 16, 4 -> кратно

Console.Clear();
Console.Write("Введите первое число: ");
int first = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int second= Convert.ToInt32(Console.ReadLine());
bool Multiply(int num1, int num2)// создали метод, ввели параметры num1 и num2
 // тип данных bool, логический тип, возвращает true или false
{
    return num1 % num2 == 0; // метод проверяет остаток от деления 
    // возвращает лоибо true либо false
}
bool result = Multiply(first,second); 
// вызываем (запускаем) метод для проверки введеных чисел 
// в переменную  result записывается  true  или false
if(result) Console.WriteLine($"{first} кратно {second}");
 // если true
else Console.WriteLine($"{first} не кратно {second}, остаток {first % second}");
//  если false
