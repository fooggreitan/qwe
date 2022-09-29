Console.Write("Имя: ");
string user = Console.ReadLine();

if(user.ToLower() == "маша")
{
    Console.WriteLine("Ура, это же Маша");

}
else
{
    Console.Write("Привет, ");
    Console.Write(user);
}