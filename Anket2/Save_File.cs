using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Anket2
{
    public static class Save_File
    {
        public static void save_to_json(string file_name, List<Person> people)
        {
            JsonSerializerOptions serializerOptions = new JsonSerializerOptions();
            serializerOptions.WriteIndented = true;


            string jsonstr = JsonSerializer.Serialize(people,serializerOptions);
           

            File.WriteAllText($"../../../{file_name}.json", jsonstr);
        }

        public static List<Person> deserialize(string file_name)
        {
            List<Person> users;
            string path = $"../../../{file_name}.json";

            if (!File.Exists(path))
            {
                return null; 
            }
            else if (new FileInfo(path).Length == 0)
            {
                return new List<Person>();
            }
            else
            {
                string txt = File.ReadAllText(path);
                users = System.Text.Json.JsonSerializer.Deserialize<List<Person>>(txt);
            }
            return users;
        }
    }
}
