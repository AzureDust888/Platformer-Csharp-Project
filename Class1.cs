using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Text.Json;
using System.IO;
using System.Windows.Forms;

namespace Platformer_Csharp_Project
{
    static class Class1
    {
        public static int score = 0;
        public static int max_score=0;
        public static async Task saveScore(int sc)
        {
            var option = new JsonSerializerOptions()
            {
                WriteIndented = true
            };
            using (FileStream fs = new FileStream("Scores.json", FileMode.Create))
            {
                await System.Text.Json.JsonSerializer.SerializeAsync(fs, sc);
            }
        }
        public static async void loadScore()
        {
            var options = new JsonSerializerOptions()
            {
                WriteIndented = true
            };
            using (FileStream fs = new FileStream("Scores.json", FileMode.Open))
            {
                max_score = await System.Text.Json.JsonSerializer.DeserializeAsync<int>(fs);
            }
        }
    }
}
