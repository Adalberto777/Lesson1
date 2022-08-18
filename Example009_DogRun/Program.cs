int speed_friend_one = 4;
int speed_friend_two = 3;
int speed_dog = 10;
int distance = 1000;
int distance_limit = 10;
int take_down = 0;
int dog_direction = 1;
int speed=0;
int time_to_visit = 0;
while(distance > distance_limit)
{
    if(dog_direction == 1)
    {
        speed = speed_dog+speed_friend_two;
    }
    else
    {
        speed = speed_dog+speed_friend_one;
    }
time_to_visit = distance / speed;
distance=distance-time_to_visit*(speed_friend_one+speed_friend_two);
take_down = take_down + 1;   
}
Console.WriteLine(take_down);