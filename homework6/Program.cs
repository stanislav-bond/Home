/*
Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223 -> 4
*/

string inputStr = ReadString("Введите числа через зяпятую: ");
int count = 0;
string tmpStr = string.Empty;

for (int i = 0; i < inputStr.Length; i++)
{
    if (inputStr[i] != ',') tmpStr += inputStr[i];
    else
    {
        if (Convert.ToInt32(tmpStr) > 0) count++;
        tmpStr = string.Empty;
    }
}
if (Convert.ToInt32(tmpStr) > 0) count++;

Console.WriteLine($"Введено {count} чисел больше 0.");

// Функция ввода ( строки )
string ReadString(string message)
{
    Console.Write(message);
    return Console.ReadLine();
}


/* 
Задача 43: 
Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
*/

double b1 = ReadTerminal("Введите b1: ");
double k1 = ReadTerminal("Введите k1: ");
double b2 = ReadTerminal("Введите b2: ");
double k2 = ReadTerminal("Введите k2: ");
 
double x = -(b1 - b2) / (k1 - k2);
double y = k1 * x + b1;
 
x = Math.Round(x, 3);
y = Math.Round(y, 3);
 
Console.WriteLine($"b1 = {b1},k1 = {k1},b2 = {b2},k2 = {k2} -> ({x};{y})");


// Функция ввода ( строки )
double ReadTerminal(string msg)
{
    Console.Write(msg);
    return Convert.ToDouble(Console.ReadLine());
}