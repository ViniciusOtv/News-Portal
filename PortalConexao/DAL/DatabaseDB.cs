using System;
using PortalConexao.Models;
using System.Data.Entity;
using System.Web;
using System.Linq;
using System.Collections.Generic;

namespace PortalConexao.DAL
{
    public class DatabaseDB : DbContext
    {
 
        public IDbSet<Cidade> Cidades { get; set; }

        public IDbSet<Noticia> Noticias { get; set; }

        public IDbSet<Categoria> Categorias { get; set; }

        static private string GetConnectionString()
        {
            return @"Data Source=LAPTOP-70KGFJC5;Initial Catalog=ConexaoDb; Integrated Security=true;";
        }

        public DatabaseDB() : base(GetConnectionString())
        {
            GetConnectionString();
        }
    }
}
