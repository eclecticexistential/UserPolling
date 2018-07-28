using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Voting.Models
{
    public class VoteLogic
    {
        public void CastVote(VoteForm vote)
        {
            using (var questions = new VoteContext())
            {
                var currQuest = questions.AskedQuestions.SingleOrDefault(x => x.Question == vote.Question);
                var hasAsked = questions.UserVotes.SingleOrDefault(x => x.QuestionsId == currQuest.Id && x.UserId == vote.UserId);
                if (hasAsked == null)
                {
                    var addVoteToDB = new UserVote()
                    {
                        UserId = vote.UserId,
                        QuestionsId = currQuest.Id,
                        Vote = vote.Vote
                    };
                    questions.UserVotes.Add(addVoteToDB);
                    if (vote.Vote == "Yes")
                    {
                        currQuest.For += 1;
                    }
                    else
                    {
                        currQuest.Against += 1;
                    }
                    currQuest.Votes += 1;
                    questions.SaveChanges();
                }
            }
        }
    }
}