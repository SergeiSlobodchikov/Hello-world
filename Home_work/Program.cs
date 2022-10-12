int count = 0;
double distance = 10000;
double firstfriendspeed = 1;
double secondfriendspeed = 2;
double dogspeed = 5;
int friend = 2;
double time = 0;

while(distance > 10)
{
    if(friend==1)
    {
        time = (distance/(firstfriendspeed+dogspeed));
        friend = 2;
    }
    if(friend==2)
    {
        time = (distance/(secondfriendspeed+dogspeed));
        friend = 1;
    }
    distance = distance - (firstfriendspeed + secondfriendspeed) * time;
    count = count + 1;
}

Console.Write("Собака пробежит ");
Console.Write(count);
Console.Write(" раз");