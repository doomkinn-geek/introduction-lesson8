using System;
using System.Resources;

namespace task1
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine($"{Properties.Resources.Greetings}");
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            if (Properties.Resources.UserName.Trim() != "")
            {
                Console.WriteLine($"Имя пользователя: {Properties.Resources.UserName}");
            }
            else
            {
                Console.Write("Введите имя пользователя: ");
                string userName = Console.ReadLine();
                IResourceWriter writer = new ResourceWriter("myResources.resources");
                writer.AddResource("UserName", userName);                
            }
            if (Properties.Resources.Age.Trim() != "")
            {
                Console.WriteLine($"Возраст пользователя: {Properties.Resources.Age}");
            }
        }
    }
}
