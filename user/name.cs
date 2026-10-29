using System;
using System.IO;

namespace user
{
    class Name
    {
        public static void GetName()
        {
            // Чтение содержимого файла lang.txt
            string read = File.ReadAllText("lang.txt");
            
            // Запись имени пользователя в файл name.txt в зависимости от языка
            if (read == "en")
            {
                Console.WriteLine("Enter your name");
                string? name = Console.ReadLine();
                File.WriteAllText("name.txt", name);
                File.WriteAllText("reg.txt", "1");
            }
            else if (read == "ru")
            {
                Console.WriteLine("Введите ваше имя");
                string? name = Console.ReadLine();
                File.WriteAllText("name.txt", name);
                File.WriteAllText("reg.txt", "1");
            }
        }
    }
}