Console.Write("Введите имя пользователя: ");
string username = Console.ReadLine();

if(username.ToLower() == "алёна")
{
    Console.WriteLine("Ура, это же АЛЁНА!");
}
else
{
    Console.WriteLine("Привет, ");
    Console.WriteLine(username);
}