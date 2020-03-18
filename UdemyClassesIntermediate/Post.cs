using System;
using System.Collections.Generic;
using System.Text;

namespace UdemyClassesIntermediate
{
    public class Post
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime Created { get; set; }
        public int Votes { get; set; }

        public void UpVote()
        {
            Votes++;
        }
        public void DownVote()
        {
            Votes--;
        }

        public int VotePoints()
        {
            return Votes;
        }
    }
}
