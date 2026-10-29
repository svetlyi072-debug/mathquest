using System;
using System.IO;

namespace user
{
    class Lang
    {

        public static string PathToFile = "lang.txt";
        public static byte? lang;
        public static void GetData()
        {
            Console.WriteLine("Select ur language/Выберите ваш язык");
            Console.WriteLine("0 -- en, 1 -- ru");
            lang = Convert.ToByte(Console.ReadLine());
             
            Write();
        }

        public static void Write()
        {
            if (lang == 0)
            {
                File.AppendAllText(PathToFile, "en");
            }
            else if (lang == 1)
            {
                File.WriteAllText(PathToFile, "ru");
            }
            else
            {
                Console.WriteLine("ERROR!/ОШИБКА!");
                Console.WriteLine("0 -- en, 1 -- ru");
                lang = Convert.ToByte(Console.ReadLine());
                Write();
            }
        }
    }
}