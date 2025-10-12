using System;
using FireFighter_1;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace FireFighter_1
{
    public class SaveInfo
    {
        private static string filePath = "players.json";
        public static void SavePlayers(List<Player> users)
        {
            var json = JsonSerializer.Serialize(users, new JsonSerializerOptions { WriteIndented = true});
            File.WriteAllText(filePath, json);

            File.WriteAllText(filePath, json);
        }

        public static List<Player> LoadAllUsers()
        {

            if (!File.Exists(filePath))
                return new List<Player>();
            

            var json = File.ReadAllText(filePath);
            return JsonSerializer.Deserialize<List<Player>>(json) ?? new List<Player>();
            
        }

        public static Player? FindUser(string name, string idCode, List<Player> users)
        {
            return users.FirstOrDefault(u => u.Name == name && u.IdCode == idCode);

        }

        
    }
}
