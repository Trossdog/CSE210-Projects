using System;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        Video Minecraft = new Video("EPIC MINECRAFT GAMEPLAY", "Pewdiepie", 120);
        Minecraft.AddComment("User1: John Hamburg", "Great video!");
        Minecraft.AddComment("User2: katie nesshoffer", "Nice content.");
        Minecraft.AddComment("User3: Billy", "First");
        Minecraft.AddComment("User4: FreeVBucks","Click on this link for free v-bucks!");
        videos.Add(Minecraft);

        Video Fails = new Video("Skateboarding Fails", "Ashton Quinton", 180);
        Fails.AddComment("User1: Shion the conquer", "Awesome video!");
        Fails.AddComment("User2: dumb_guy", "This sucked");
        Fails.AddComment("User3: Stone Schneider", "Wow this was hilarious");
        Fails.AddComment("User4: Ashton Quinton", "Please stop making videos");
        videos.Add(Fails);

        Video TierList = new Video("Best Weaspons in Doom (2016)", "Pyrocynical", 240);
        TierList.AddComment("User 1: Spencer Astel", "I like the BFG the best");
        TierList.AddComment("User 2: David Tolson", "@Spencer Astel The BFG sucks");
        TierList.AddComment("User 3: Quinn Ward", "How did I end up here?");
        TierList.AddComment("User 4: Carrson Steele", "You made an editing mistake and put your face in the video");
        videos.Add(TierList);

        Video Control = new Video("Control Part 4 | Dead Letters", "Trossdog", 742);
        Control.AddComment("User 1: Cole Duncan", "Yooooo, unrelease this");
        Control.AddComment("User 2: Bender Hampton", "This Video is really good when you have it on mute and then close the tab");
        Control.AddComment("User 3: Emma McGee", "I love you");
        Control.AddComment("User 4: Max Imillyon", "This sure was spooky");
        videos.Add(Control);

        
        foreach (var video in videos)
        {
            Console.WriteLine("Title: " + video.GetTitle());
            Console.WriteLine("Author: " + video.GetCreator());
            Console.WriteLine("Length (seconds): " + video.GetLengthInSeconds());
            Console.WriteLine("Number of Comments: " + video.GetNumberOfComments());

            Console.WriteLine("Comments:");
            foreach (var comment in video.GetAllComments())
            {
                Console.WriteLine(comment.GetCommentersName() + ": " + comment.GetCommentText());
            }

            Console.WriteLine();
        }
        
    }
}