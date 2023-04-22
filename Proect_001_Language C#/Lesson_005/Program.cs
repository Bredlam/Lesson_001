Console.Write("Введите имя: ");
string UserName = Console.ReadLine() ?? "";
string ControlName = "Андрей";
if (ControlName.ToLower() == UserName.ToLower())
{
  Console.Write("Привет, " + ControlName + " ты тут главный!!!");  
}
else
{
    Console.Write("Привет, незнакомец!");  
}