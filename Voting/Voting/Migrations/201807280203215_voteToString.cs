namespace Voting.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class voteToString : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.UserVotes", "Vote", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.UserVotes", "Vote", c => c.Int(nullable: false));
        }
    }
}
