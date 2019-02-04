using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PortalConexao.Models
{
    public class Noticia
    {
        public int Id { get; set; }

        public string Titulo { get; set; }

        public string SubTitulo { get; set; }

        public string Imagem { get; set; }
        
    }
}