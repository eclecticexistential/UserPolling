using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Voting.Models
{
    public class VoteLogic
    {
        public void CastVote(string questNum, int answer, string user)
        {
            int numUse = int.Parse(questNum);
            UserVote stub = new UserVote();
            using (var questions = new VoteContext())
            {
                var currQuest = questions.AskedQuestions.SingleOrDefault(x => x.Id == numUse);
                var hasAsked = questions.UserVotes.SingleOrDefault(x => x.QuestionsId == numUse && x.UserId == user);
                if (hasAsked == null)
                {
                    stub.UserId = user;
                    stub.QuestionsId = numUse;
                    stub.Vote = answer;
                    questions.UserVotes.Add(stub);
                    if (answer == 0)
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