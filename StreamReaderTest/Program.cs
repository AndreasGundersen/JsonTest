using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

namespace StreamReaderTest
{
    class Program
    {
        static void Main(string[] args)
        {
            string line;
            using (StreamReader reader = new StreamReader("Abilities.json")) 
            {
                line = reader.ReadToEnd();
            }

            string json = line;

            List<Abilities> abilities = JsonConvert.DeserializeObject<List<Abilities>>(json);

            foreach (var ability in abilities)
            {
                Console.WriteLine(ability.Name);
                Console.WriteLine(ability.Description);
                Console.WriteLine(ability.ImageUrl);
            }





        }
    }
}
