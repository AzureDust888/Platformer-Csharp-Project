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
        static int[] mas;
        public static int max_score = 0;
        public static async Task saveScore(int sc)
        {
            var option = new JsonSerializerOptions()
            {
                WriteIndented = true
            };
            using (FileStream fs = new FileStream("Scores.json", FileMode.OpenOrCreate))
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
                mas = await System.Text.Json.JsonSerializer.DeserializeAsync<int[]>(fs);
            }
        }
        public static  void searchMaxScore()
        {
            for(int i=0;i<mas.Length;i++)
            {
                if(mas[i] > max_score)
                {
                    max_score = mas[i];
                }
            }
        }
    }
}
