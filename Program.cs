using System;
using System.IO;
using user;

namespace testH
{
    class Program
    {
        // погдотовка перменных с данными
        string name = File.ReadAllText("user/name.txt");
        string id = File.ReadAllText("ID.txt");
        int score = Convert.ToInt32(File.ReadAllText("user.score"));




        static void Main()
        {
            string reg = File.ReadAllText("user/reg.txt");

            if (reg == "1")
            {
                Firebase.SaveData();
            }
            else
            {
                Console.WriteLine(".");
                user.Lang.GetData();
                user.Name.GetName();

                // генерация нового уникального идентификатора пользователя ID
                string userID = Guid.NewGuid().ToString(); 
                File.WriteAllText("ID.txt", userID);
                File.WriteAllText("user/maxscore.txt", "0");

                Firebase.SaveData(name, score, id);
            }
        }
    }
}
