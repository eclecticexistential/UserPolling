using Voting.Models;
using System.Data.Entity;

namespace Voting
{
    public class VoteContext : DbContext
    {
        public VoteContext()
        {
            Database.SetInitializer(new DatabaseInitializer());
        }
        public DbSet<Questions> AskedQuestions { get; set; }
    }
}