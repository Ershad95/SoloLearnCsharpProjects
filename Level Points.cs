using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoloLearnCsharpProjects
{
    public class Level_Points
    {
        public int GetAllPoints(int levels)
        {
            int sum = 0;
            for (int i = 1; i <= levels; i++)
                sum += i;
            return sum;
        }
    }
}
