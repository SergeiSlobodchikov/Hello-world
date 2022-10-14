//Напишите программу, которая будет выдавать название дня недели по заданному номеру.
Console.Clear();
Console.Write("Введите число от 1 до 7: ");
int i = Math.Abs((Convert.ToInt32(Console.ReadLine())));
while (i > 7 ^ i < 1)
{
    Console.Write("Не то число");
    break;
}
while (i >= 1 && i <= 7)
{
    if (i == 1)
    {
        Console.Write("Понедельник");
        break;
    }
    if (i == 2)
    {
        Console.Write("Вторник");
        break;
    }
    if (i == 3)
    {
        Console.Write("Среда");
        break;
    }
    if (i == 4)
    {
        Console.Write("Четверг");
        break;
    }
    if (i == 5)
    {
        Console.Write("Пятница");
        break;
    }
    if (i == 6)
    {
        Console.Write("Суббота");
        break;
    }
    if (i == 7)
    {
        Console.Write("Воскресенье");
        break;
    }
    else
    {
        Console.Write("Не то число");
        break;
    }
}