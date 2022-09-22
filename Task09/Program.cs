// 9. Напишите программу, которая выводит
//  лучайное чило из отрезка [10,99] и показывает
// наибольшую цифру числа
// 78->8
// 12->2
// 85->8

int number = new Random().Next(10,100);// задаем псевдослучайное число 
int firstDigit = number / 10; // целочисленное деление на 10 - находим первую цифру
int secondDigit = number % 10; // остаток от деления на 10 -находим вторую цифру

if (firstDigit > secondDigit) Console.WriteLine($"Наибольшая цифра числа {number} -> {firstDigit}");
else Console.WriteLine ($"Наибольшая цифра числа {number} -> {secondDigit}"); 

