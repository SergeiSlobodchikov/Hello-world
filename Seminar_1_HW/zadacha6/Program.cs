Console.Clear();
Console.WriteLine("Введите число для проверки четное оно или нет");
int x = Convert.ToInt32(Console.ReadLine());
if ((x % 2) == 0)
{
    Console.WriteLine(x + " четное");
}
else
{
    Console.WriteLine(x + " нечетное");
}