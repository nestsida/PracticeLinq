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
               
            };
            
            List<string> list = videoGames.OrderBy(name =>name.Length).ToList();
            
            videoGames.ForEach(name => Console.WriteLine(name));
            Console.WriteLine("This video game has a long name.");

         
        }
    }
}
