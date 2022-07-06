using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoloLearnCsharpProjects
{
    public class Robot_barman
    {
        public int Arrange_drinks(int drinks,int shelves)
        {
            try
            {
                return drinks / shelves;
                //your code goes here
            }
            /*
             * 1. DivideByZeroException => "At least 1 shelf"
             * 2. FormatException => "Please insert an integer"
            */
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("At least 1 shelf");
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Please insert an integer");
            }
            return 0;
        }
    }
}
