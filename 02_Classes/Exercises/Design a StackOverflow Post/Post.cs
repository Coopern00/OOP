using System;
using System.Collections.Generic;
using System.Text;

namespace Post
{
    class Post
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime Created { get; set; }
        public int Votes { get; private set; }

        public Post(string title, string description)
        {
            this.Title = title;
            this.Description = description;
            Created = DateTime.Now;
        }

        public void UpVote()
        {
            Votes++;
        }

        public void DownVote()
        {
            Votes--;
        }

    }
}
