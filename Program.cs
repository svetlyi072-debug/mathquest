using System;
using System.IO;
using user;

namespace testH
{
    class Program
    {
        static void Main()
        {
            

            string reg = File.ReadAllText("user/reg.txt");

            if (reg == "1")
            {
                
            }
            else
            {
                Console.WriteLine(".");
                user.Lang.GetData();
                user.Name.GetName();

                // генерация нового уникального идентификатора пользователя ID
                string userID = Guid.NewGuid().ToString(); 
                File.WriteAllText("ID.txt", userID);
            }
        }
    }
}
