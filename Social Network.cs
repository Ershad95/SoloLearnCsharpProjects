using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoloLearnCsharpProjects
{
    public class Social_Network
    {
        public class Post
        {
            private string text;

            //write a constructor here
            public Post()
            {
                Console.WriteLine("New post");
            }

            public void ShowPost()
            {
                Console.WriteLine(text);
            }

            //write a property for member text
            public string Text
            {
                get { return text; }
                set { text = value; }
            }
        }
    }
}
