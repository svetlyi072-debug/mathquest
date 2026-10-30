using System;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using user;

namespace testH
{
    class Firebase
    {
        // URL базы данных FireBase
        private static readonly string firebaseUrl = "https://math-b39f1-default-rtdb.europe-west1.firebasedatabase.app/"; 

        public static void SaveData(string name, int score, string id)
        {

            // Объект данных о игроке
            var user = new
            {
                name = Name,
                score = Score,
                id = ID
            };

            // Превращение string в JSON
            string jsonStr = JsonSerializer.Serialize(user);
            var content = new StringContent(jsonStr, Encoding.UTF8, "application/json");

            using (HttpClient client = new HttpClient())
            {
                string requstUrl = $"{firebaseUrl}users/{id}.json";

                HttpResponseMessage resp = client.PutAsync(requstUrl, content).Result;

                if (resp.IsSuccessStatusCode)
                {
                    Console.WriteLine("Круто");
                }
                else
                {
                    Console.WriteLine("Говно");
                }
            }
        }
    }
}