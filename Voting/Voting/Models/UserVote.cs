﻿namespace Voting.Models
{
    public class UserVote
    {
        public int Id { get; set; }
        public string UserId { get; set; }
        public int QuestionsId { get; set; }
        public int Vote { get; set; }
    }
}