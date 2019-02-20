namespace PortalConexao.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class atualizadatabase : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Categorias",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nome = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Noticias",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Titulo = c.String(),
                        SubTitulo = c.String(),
                        Conteudo = c.String(),
                        DataPublicacao = c.DateTime(nullable: false),
                        DetalheImagem = c.String(),
                        Imagem = c.String(),
                        CidadeId = c.Int(nullable: false),
                        CategoriaId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Categorias", t => t.CategoriaId, cascadeDelete: true)
                .ForeignKey("dbo.Cidades", t => t.CidadeId, cascadeDelete: true)
                .Index(t => t.CidadeId)
                .Index(t => t.CategoriaId);
            
            CreateTable(
                "dbo.Cidades",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nome = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Noticias", "CidadeId", "dbo.Cidades");
            DropForeignKey("dbo.Noticias", "CategoriaId", "dbo.Categorias");
            DropIndex("dbo.Noticias", new[] { "CategoriaId" });
            DropIndex("dbo.Noticias", new[] { "CidadeId" });
            DropTable("dbo.Cidades");
            DropTable("dbo.Noticias");
            DropTable("dbo.Categorias");
        }
    }
}
