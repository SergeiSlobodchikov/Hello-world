Console.Clear();
Console.Write("Введите трехзначное число: ");
int num = Math.Abs((Convert.ToInt32(Console.ReadLine())));
if (num > 99 && num <= 999)
{
    Console.Write("Последняя цифра: " + num % 10);
}
else
{
    Console.WriteLine("Введенное число не трехзначное");
}