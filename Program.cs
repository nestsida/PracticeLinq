using System;
using System.Collections.Generic;
using System.Linq;

namespace PracticeLinq
{
    class Program
    {
        static void Main(string[] args)
        {
            
            var videoGames = new List<string>();
            {
                videoGames.Add("Pokemon");
                videoGames.Add("Frozen");
                videoGames.Add("The bear went over the mountain");
                videoGames.Add("She dances in the rain");
                videoGames.Add("no need for games");
                videoGames.Add("");
            };
            videoGames.Where(videoGames => videoGames.Contains(""));
            Console.WriteLine("List all the video games: {videoGames}");
            Console.WriteLine("This video game has a long name.");
        }
    }
}
