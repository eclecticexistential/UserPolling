namespace Voting.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class questionIdAsString : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.UserVotes", "QuestionAnswered", c => c.String());
            DropColumn("dbo.UserVotes", "QuestionId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.UserVotes", "QuestionId", c => c.Int(nullable: false));
            DropColumn("dbo.UserVotes", "QuestionAnswered");
        }
    }
}
