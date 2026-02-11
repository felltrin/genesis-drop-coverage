string aFriend = "Bill";
Console.WriteLine("Hello " + aFriend);

aFriend = "Maria";
Console.WriteLine($"Hello {aFriend}");

string firstFriend = "Maria";
string secondFriend = "Sage";
Console.WriteLine($"My friends are {firstFriend} and {secondFriend}");

Console.WriteLine($"The name {firstFriend} has {firstFriend.Length} letters.");
Console.WriteLine($"The name {secondFriend} has {secondFriend.Length} letters.");

string[] firstFriendSplit = firstFriend.Split('a');
for (int i = 0; i < firstFriendSplit.Length; i++)
{
    Console.WriteLine(firstFriendSplit[i]);
}