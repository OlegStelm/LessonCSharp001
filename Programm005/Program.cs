Console.Write("Enter user name ");
string username = Console.ReadLine();

if(username.ToLower() == "Masha")
{
    Console.WriteLine("Hooray! It's MASHA!");
}
else
{
    Console.Write("Wazzup, ");
    Console.Write(username);
    Console.WriteLine("!");
}
