using System.Collections.Generic;

namespace Voting.Models
{
    public class Questions
    {
        public int Id { get; set; }
        public string Question { get; set; }
        public int Votes { get; set; }
        public int For { get; set; }
        public int Against { get; set; }
    }
}