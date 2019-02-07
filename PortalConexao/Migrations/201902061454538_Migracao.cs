namespace PortalConexao.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Migracao : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Noticias", "Conteudo", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Noticias", "Conteudo");
        }
    }
}
