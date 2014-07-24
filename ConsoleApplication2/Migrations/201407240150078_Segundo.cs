namespace ConsoleApplication2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Segundo : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.TipoDeDados",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        TipoString = c.String(unicode: false),
                        TipoData = c.DateTime(nullable: false, precision: 0),
                        TipoBool = c.Boolean(nullable: false),
                        TipoDecimal = c.Decimal(nullable: false, precision: 18, scale: 2),
                        TipoDouble = c.Double(nullable: false),
                        TipoDataNulo = c.DateTime(precision: 0),
                        TipoFLoat = c.Single(nullable: false),
                        TipoByte = c.Byte(nullable: false),
                        TipoArrayByte = c.Binary(),
                        PessoaId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Pessoa", t => t.PessoaId)
                .Index(t => t.PessoaId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.TipoDeDados", "PessoaId", "dbo.Pessoa");
            DropIndex("dbo.TipoDeDados", new[] { "PessoaId" });
            DropTable("dbo.TipoDeDados");
        }
    }
}
