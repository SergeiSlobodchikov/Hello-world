// 1 Напишите программу, которая на вход принимает число и выдаёт его квадрат (число умноженное на само себя).
Console.Clear();
Console.WriteLine("Программа, которая на вход принимает два числа и проверяет, является ли число квадратом второго");
Console.Write("Введите число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число: ");
int number2 = Convert.ToInt32(Console.ReadLine());
int sqrt1 = Convert.ToInt32(Math.Pow(number1, 2));
int sqrt2 = Convert.ToInt32(Math.Pow(number2, 2));
if(sqrt1==number2 ^ sqrt2==number1)
{
    Console.WriteLine("Да");
}
else
{
    Console.WriteLine("Нет");
}


