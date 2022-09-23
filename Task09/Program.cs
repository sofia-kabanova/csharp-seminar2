// 9. Напишите программу, которая выводит
//  лучайное чило из отрезка [10,99] и показывает
// наибольшую цифру числа
// 78->8
// 12->2
// 85->8
// 88 - цифры одинаковые

int number = new Random().Next(10,100);// исходные данные/ задаем псевдослучайное число 
//int firstDigit = number / 10; // целочисленное деление на 10 - находим первую цифру
//int secondDigit = number % 10; // остаток от деления на 10 -находим вторую цифру

// if (firstDigit > secondDigit) Console.WriteLine($"Наибольшая цифра числа {number} -> {firstDigit}");
// else Console.WriteLine ($"Наибольшая цифра числа {number} -> {secondDigit}"); 

// if (firstDigit == secondDigit) Console.WriteLine($"Цифры равны");
// else {
// int max = firstDigit > secondDigit ?  firstDigit : secondDigit;// тернарный оператор, тоже условный оператор
// в переменную max записываем firstDigit либо secondDigit
// если (=) firstDigit>secondDigit,  тогда (?)  в переменную max записываем firstDigit
// иначе (:) переменной max присываиваем значение secondDigit
// Console.WriteLine($"Наибольшая цифра числа {number} -> {max}");
// }
int MaxDigit(int num) //создаем метод. Переменная не должна иметь такое же название,
// как при начальном условии-создаем псевдоним.
{ // тело метода. внутри тела реализуем логику метода
int firstDigit = num / 10; // целочисленное деление на 10 - находим первую цифру
int secondDigit = num % 10; 
return firstDigit > secondDigit ?  firstDigit : secondDigit; // возвращаем значение 
// либо firstDigit  либо secondDigit; переменная здесь не нужна
}

int maxDigit = MaxDigit(number);//переменные начинаются с маленьких букв/
// вызываем метод MaxDigit 
Console.WriteLine($"Наибольшая цифра числа {number} -> {maxDigit}");