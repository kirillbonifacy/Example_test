Console.Write("Введите имя ползователя: ");
string username = Console.ReadLine();

if(username.ToLower() == "даша")
{
    Console.WriteLine("Урааа, это ДАША!!!");
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}