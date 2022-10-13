Console.Clear();
int count = 0;
Console.WriteLine("Введите расстояние (м)");
double distance = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите скорость 1-го друга (м/с)"); 
double firstfriendspeed = Convert.ToDouble(Console.ReadLine()); 
Console.WriteLine("Введите скорость 2-го друга (м/с)"); 
double secondfriendspeed = Convert.ToDouble(Console.ReadLine()); 
Console.WriteLine("Введите скорость собаки (м/с)"); 
double dogspeed = Convert.ToDouble(Console.ReadLine()); 
int friend = 2;
double time = 0;
Console.WriteLine(" Дистаниция между друзьями " + distance);
Console.WriteLine(" Сколько пробежала собака " + count + " раз");
Console.WriteLine();
while(distance>1)
{
    if(friend==1)
    {
        time = (distance/(firstfriendspeed+dogspeed));
        friend = 2;
    }
    else
    {
        time = (distance/(secondfriendspeed+dogspeed));
        friend = 1;
    }
    distance = distance - (firstfriendspeed + secondfriendspeed) * time;
    count = count + 1;
    Console.WriteLine(" Дистаниция между друзьями " + distance);
    Console.WriteLine(" Сколько пробежала собака " + count + " раз");
    Console.WriteLine();
}
Console.WriteLine("Собака пробежит " + count + " раз");
Console.WriteLine();