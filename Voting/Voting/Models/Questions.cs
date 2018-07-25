using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

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