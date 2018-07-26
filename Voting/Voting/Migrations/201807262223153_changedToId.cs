namespace Voting.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class changedToId : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.UserVotes", "QuestionsId", c => c.Int(nullable: false));
            DropColumn("dbo.UserVotes", "QuestionAnswered");
        }
        
        public override void Down()
        {
            AddColumn("dbo.UserVotes", "QuestionAnswered", c => c.String());
            DropColumn("dbo.UserVotes", "QuestionsId");
        }
    }
}
