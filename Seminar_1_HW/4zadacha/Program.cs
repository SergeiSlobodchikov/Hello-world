Console.Clear();
Console.WriteLine("Введите число A");
double A = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите число B");
double B = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите число C");
double C = Convert.ToDouble(Console.ReadLine());
double max1 = Math.Max(A, B);
Console.WriteLine("Максимальное число из трех чисел " +  Math.Max(max1, C));