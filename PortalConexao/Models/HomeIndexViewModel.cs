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

        public int? CidadeSelecionada { get; set; }
    }
}