namespace ConsoleApplication2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Terceiro : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Pessoa", "Nome", c => c.String(maxLength: 100, storeType: "nvarchar"));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Pessoa", "Nome", c => c.String(unicode: false));
        }
    }
}
