namespace Voting.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using Voting.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<Voting.VoteContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Voting.VoteContext context)
        {
            context.AskedQuestions.AddOrUpdate(p => p.Id,
            new Questions { Id = 0, Question = "Will the sun shine tomorrow?", Votes = 100, For = 100, Against = 0 },
            new Questions { Id = 1, Question = "Is red the same as green?", Votes = 100, For = 0, Against = 100 },
            new Questions { Id = 2, Question = "Is purple the best color?", Votes = 0, For = 0, Against = 0 },
            new Questions { Id = 3, Question = "Can dogs and cats be friends?", Votes = 100, For = 50, Against = 50 },
            new Questions { Id = 4, Question = "Will we ever find a wormhole?", Votes = 50, For = 20, Against = 30 }
            );
        }
    }
}
