Console.Write("Введите имя: ");
string UserName = Console.ReadLine();
string ControlName = "Андрей";
if (ControlName == UserName)
{
  Console.Write("Привет " + ControlName);  
}
else
{
    Console.Write("Привет, незнакомец!");  
}