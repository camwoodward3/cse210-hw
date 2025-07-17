using System;

class Program
{
    static void Main(string[] args)
    {
        List<Comments> list1 = new List<Comments>
        {
            new Comments("Cameron", "Nice job!"),
            new Comments("Zachary", "Heck ya!!!"),
            new Comments("Isabelle", "No way!"),
            new Comments("Jet", "This is such a good video!")
        };
        List<Comments> list2 = new List<Comments>
        {
            new Comments("Tiger", "LOL! This is so funny!"),
            new Comments("Crew", "Man, this video has such good humor."),
            new Comments("Nate", "I think I'm going to die of laughter!!!"),
            new Comments("Louie", "This is the funniest video that ever existed.")
        };
        List<Comments> list3 = new List<Comments>
        {
            new Comments("Alexa", "Pink"),
            new Comments("Evie", "Purple"),
            new Comments("Asher", "Red"),
            new Comments("Remmington", "Blue")
        };
        List<Comments> list4 = new List<Comments>
        {
            new Comments("Beckham", "THAT WAS SO SCARY!!!"),
            new Comments("Morgan", "It was soo scary that I passed out on the floor"),
            new Comments("Peyton", "Cool!!! Scary stuff is the best!"),
            new Comments("Goldie", "Everyone that is scared of this video are babies!")
        };


        List<Video> videoList = new List<Video>
        {
            new Video("Epic War Battle", "HighSc0re", 12, list1),
            new Video("Try Not to Laugh Extreme", "LionMaster", 16, list2),
            new Video("What is everyone's favorite color?", "Nerd4055", 1, list3),
            new Video("Jumpscare Surprise", "GothGirl1917", 20, list4)
        };
        foreach (Video video in videoList)
        {
            video.DisplayVideoInfo();
            video.DisplayComments();
            Console.WriteLine();
        }
    }
    
}