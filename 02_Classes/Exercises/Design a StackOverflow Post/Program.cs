using System;
using System.ComponentModel;

namespace Post
{
    class Program
    {
        static void Main(string[] args)
        {
            string description = "Its a question about classes";
            string postName = "Classes";

            var post = new Post(postName, description);
            // this is for testing if the creation date is correct
            Console.WriteLine(post.Created);
			
			// this is for testing if the description works
			Console.WriteLine(post.Description)

            //this is for testing if the UpVote method works
            post.UpVote();
            post.UpVote();
            post.UpVote();

            Console.WriteLine(post.Votes);

            // this is for testing if the DownVote method works
            post.DownVote();
            post.DownVote();

            Console.WriteLine(post.Votes);
            
            
        }
    }
}
