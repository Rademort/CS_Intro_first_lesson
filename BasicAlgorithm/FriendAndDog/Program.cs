// Собака бегает между двумя друзьями

int count, firstFriendSpeed, secondFriendSpeed, dogSpeed, currentFriend;
double time, distance;
count = 0;
distance = 10000;
firstFriendSpeed = 1;
secondFriendSpeed = 2;
dogSpeed = 5;
currentFriend = 2;
while (distance > 10)
{
    if (currentFriend == 1)
    {
        time = distance / (firstFriendSpeed + dogSpeed);
        currentFriend = 2;
    }
    else
    {
        time = distance / (secondFriendSpeed + dogSpeed);
        currentFriend = 1;
    }
    distance = distance - ((firstFriendSpeed + secondFriendSpeed) * time);
    count++;
}
System.Console.WriteLine(count);