using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PortalConexao.Models
{
    public class HomeIndexViewModel
    {

        public Cidade[] Cidades { get; set; }

        public Noticia[] Noticias { get; set; }

        public Categoria[] Categorias { get; set; }

        public Carousel[] Carousels { get; set; }

        public int? CidadeSelecionada { get; set; }

        public int? CategoriaSelecionada { get; set; }
    }
}