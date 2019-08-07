using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QAChallenge
{
   
    
        class codechallenge3
        {
            static Random rnd = new Random();
            static void Main(string[] args)
            {
                var responses = new List<string>() { "Thi2s ", "is4 ", "a2 ", "book3 " };
                var shuffle = new List<string>();
                for (int ix = responses.Count; ix > 0; --ix)
                {
                    int index = rnd.Next(0, ix);
                    shuffle.Add(responses[index]);
                    responses.RemoveAt(index);
                }
                foreach (string word in shuffle)
                    Console.Write(word);
                Console.ReadLine();
            }
        }

    }

