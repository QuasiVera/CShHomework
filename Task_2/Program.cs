// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, 
// какое число большее, а какое меньшее.

Console.Write("Введите целое число 1 и нажмите enter: ");
string userInput1 = Console.ReadLine() ?? "";

Console.Write("Введите целое число 2 и нажмите enter: ");
string userInput2 = Console.ReadLine() ?? "";

int number1 = int.Parse(userInput1);
int number2 = int.Parse(userInput2);

if (number1>number2)
{
    Console.WriteLine($"{number1} -> max, {number2} -> min");
}
else
{
    Console.WriteLine($"{number2} -> max, {number1} -> min");
}