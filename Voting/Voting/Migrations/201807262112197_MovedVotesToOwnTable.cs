namespace Voting.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MovedVotesToOwnTable : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.UserVotes", "Questions_Id", "dbo.Questions");
            DropIndex("dbo.UserVotes", new[] { "Questions_Id" });
            DropColumn("dbo.UserVotes", "Questions_Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.UserVotes", "Questions_Id", c => c.Int());
            CreateIndex("dbo.UserVotes", "Questions_Id");
            AddForeignKey("dbo.UserVotes", "Questions_Id", "dbo.Questions", "Id");
        }
    }
}
