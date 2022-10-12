Console.Clear();
int count = 0;
Console.WriteLine("Введите расстояние (м)");
double distance = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите скорость 1-го друга (м/с)"); 
double firstfriendspeed = Convert.ToInt32(Console.ReadLine()); 
Console.WriteLine("Введите скорость 2-го друга (м/с)"); 
double secondfriendspeed = Convert.ToInt32(Console.ReadLine()); 
Console.WriteLine("Введите скорость собаки (м/с)"); 
double dogspeed = Convert.ToInt32(Console.ReadLine()); 
int friend = 2;
double time = 0;
while(distance>10)
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
}
Console.WriteLine("Собака пробежит " + count + " раз");