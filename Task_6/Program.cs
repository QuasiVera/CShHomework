// Задача 6: Напишите программу, которая на вход принимает число и выдаёт,
// является ли число чётным (делится ли оно на два без остатка).

Console.WriteLine("Введите число и нажмите enter");
string InputA = Console.ReadLine() ?? "";
int a = Convert.ToInt32(InputA);
// double res = a%2;
if (a%2==0)
{
    Console.WriteLine($"Число {a} четное");
}
else
{
    Console.WriteLine($"Число {a} нечетное");
}