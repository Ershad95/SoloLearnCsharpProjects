using SoloLearnCsharpProjects;
using System;
using static SoloLearnCsharpProjects.Social_Network;

namespace MyApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string postText = Console.ReadLine();

            Post post = new Post();
            post.Text = postText;
            post.ShowPost();
        }
    }
}
