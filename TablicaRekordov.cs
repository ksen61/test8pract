using System.IO;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Pract8
{
    public class TablicaRekordov
    {
        private static List<User> users = new List<User>();

        public static void Load(string fileName)
        {
            if (File.Exists(fileName))
            {
                string json = File.ReadAllText(fileName);
                var deserialized = JsonConvert.DeserializeObject<List<User>>(json);
                if (deserialized != null)
                {
                    users = deserialized;
                }
            }
        }

        public static void UpdateUser(User user)
        {
            User existingUser = users.Find(u => u.Name == user.Name);
            if (existingUser == null)
            {
                users.Add(user);
            }
            else
            {
                existingUser.CharactersPerMinute = user.CharactersPerMinute;
                existingUser.CharactersPerSecond = user.CharactersPerSecond;
            }
        }

        public static void Show()
        {
            Console.Clear();
            Console.WriteLine("Таблица рекордов");
            Console.WriteLine("----------------");
            foreach (User user in users)
            {
                Console.WriteLine($"{user.Name} | {user.CharactersPerMinute:0} символов в минуту | {user.CharactersPerSecond:0.00} символов в секунду");
            }
        }

        public static void Save(string fileName)
        {
            string json = JsonConvert.SerializeObject(users);
            File.WriteAllText(fileName, json);
        }
    }
}