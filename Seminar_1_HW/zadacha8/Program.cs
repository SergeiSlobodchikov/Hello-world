Console.Clear();
Console.WriteLine("Введите число N");
int N = Convert.ToInt32(Console.ReadLine());
int i = 0;
int x = 0;
while (i < N - 1)
{
    i = i + 2;
    x = x + 1;
    Console.WriteLine(x + ". " + i);
}
Console.WriteLine("Конец");