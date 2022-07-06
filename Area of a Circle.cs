using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoloLearnCsharpProjects
{
    public class Area_of_a_Circle
    {
        const double pi = 3.14;
        
        public double GetArea(double raduis) { 
            return Math.Pow(raduis,2) * pi;
        }

    }
}
