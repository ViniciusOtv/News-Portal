using MySql.Data.Entity;
using PortalConexao.Models;
using System.Data.Entity;

namespace PortalConexao.DAL
{
    [DbConfigurationType(typeof(MySqlEFConfiguration))]
    public class DatabaseDB : DbContext
    {
        public DatabaseDB()
            : base("JornalDb")
        {

        }

        public static DatabaseDB Create()
        {
            return new DatabaseDB();
        }

        public IDbSet<Cidade> Cidades { get; set; }

        public IDbSet<Noticia> Noticias { get; set; }

        public IDbSet<Categoria> Categorias { get; set; }

        public IDbSet<Carousel> Carousels { get; set; }

    }
}
