namespace Voting.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UserAndQuestionId : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.UserVotes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        QuestionId = c.Int(nullable: false),
                        UserId = c.String(),
                        Vote = c.Boolean(nullable: false),
                        Questions_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Questions", t => t.Questions_Id)
                .Index(t => t.Questions_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.UserVotes", "Questions_Id", "dbo.Questions");
            DropIndex("dbo.UserVotes", new[] { "Questions_Id" });
            DropTable("dbo.UserVotes");
        }
    }
}
