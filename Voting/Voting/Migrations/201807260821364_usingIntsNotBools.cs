namespace Voting.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class usingIntsNotBools : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.UserVotes", "Vote", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.UserVotes", "Vote", c => c.Boolean(nullable: false));
        }
    }
}
