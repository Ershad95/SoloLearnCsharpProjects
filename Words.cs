using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoloLearnCsharpProjects
{
    public class Words
    {
        string[] words = {
                "home",
                "programming",
                "victory",
                "C#",
                "football",
                "sport",
                "book",
                "learn",
                "dream",
                "fun"
            };
        public string SearchInWords(string character)
        {
            string output = "";
            foreach (var word in words)
            {
                if(word.Contains(character))
                {
                    output+=word;
                }
            }
            if(output.Length > 0)
            {
                return output;
            }
            else
            {
                return "No match";
            }
            
        }
    }
}
