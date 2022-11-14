// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе
// показывает все чётные числа от 1 до N.
// Вариант, в котором прогамма "проходит мимо нечетных", правда начало с 2, а не с 1

Console.WriteLine("Введите целое число и нажмите enter: ");
string inputN = Console.ReadLine() ?? "";
double numberN = Convert.ToDouble(inputN);
int interim = 2;

Console.Write($" {numberN} -> ");
while (interim <= numberN)
{
    Console.Write($" {interim}, ");
    interim=interim+2;
}
