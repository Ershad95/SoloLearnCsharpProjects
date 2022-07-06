using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoloLearnCsharpProjects
{
    public class Multiple_of_3
    {
        public string GetMultiple_3(int input)
        {
            var output="";
            for (int i = 1; i <= input; i++)
            {
                if (i % 3 == 0)
                {
                    output+= "*";
                }
                else
                {
                    output+= i;
                }
            }
            return output;
        }
    }
}
