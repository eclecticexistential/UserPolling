// <auto-generated />
namespace Voting.Migrations
{
    using System.CodeDom.Compiler;
    using System.Data.Entity.Migrations;
    using System.Data.Entity.Migrations.Infrastructure;
    using System.Resources;
    
    [GeneratedCode("EntityFramework.Migrations", "6.1.3-40302")]
    public sealed partial class MovedVotesToOwnTable : IMigrationMetadata
    {
        private readonly ResourceManager Resources = new ResourceManager(typeof(MovedVotesToOwnTable));
        
        string IMigrationMetadata.Id
        {
            get { return "201807262112197_MovedVotesToOwnTable"; }
        }
        
        string IMigrationMetadata.Source
        {
            get { return null; }
        }
        
        string IMigrationMetadata.Target
        {
            get { return Resources.GetString("Target"); }
        }
    }
}