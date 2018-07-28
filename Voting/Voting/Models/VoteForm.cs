using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Voting.Models
{
    public class VoteForm
    {
        public string Vote { get; set; }
        public string Question { get; set; }
        public string UserId { get; set; }
    }
}