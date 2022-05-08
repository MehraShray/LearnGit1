// See https://aka.ms/new-console-template for more information
using LearnGit1;

Console.WriteLine("Hello, World!");
Console.WriteLine("Hello, World!/ Shray");
Console.WriteLine("Hello, World!/ Nishant");
Console.WriteLine("Hello, World!/ Rupali");

Employee e = new Employee();
e.Id = 1;
e.Name = "Nishant".ToLower();
e.Address = "Kangra";


if (e.Name == "shray")
{
    e.Age = 25;

}
else if (e.Name == "Nishant".ToLower())
{
    e.Age = 27;
}
Console.WriteLine("Id:" + e.Id + e.Name + e.Address + e.Age);