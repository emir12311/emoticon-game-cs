using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace emoticon_game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int life = 3;
            Dictionary<string, string> emoticons = new Dictionary<string, string>();
            emoticons.Add(":)", "smiling");
            emoticons.Add(":(", "sad");
            emoticons.Add(":O", "shocked");
            emoticons.Add(":p", "tongue out");
            emoticons.Add(":3", "silly");
            List<string> list_Of_Emoticons = new List<string>();
            foreach (var item in emoticons.Keys)
            {
                list_Of_Emoticons.Add(item);
            }
            Random rnd = new Random();
            int random = rnd.Next(0, emoticons.Keys.Count());
            emoticons.TryGetValue(list_Of_Emoticons[random], out string picked_Meaning);

            while (life != 0)
            {
                Console.WriteLine($"The emoji description is *{picked_Meaning}*, Can you guess which emoji it is?");
                string user_Response = Console.ReadLine();
                if (user_Response == list_Of_Emoticons[random])
                {
                    break;
                }
                else
                {
                    life--;
                    Console.WriteLine("oh no.. that was wrong");
                }
            }
            if (life == 0)
            {
                Console.WriteLine("good luck next time!");
            }
            else
            {
                Console.WriteLine("good job on getting that!");
            }
            Thread.Sleep(2000);
        }
    }
}
