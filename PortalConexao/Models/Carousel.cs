using System;
using System.Collections.Generic;

namespace PortalConexao.Models
{
    public class Carousel
    {
        public int CarouselId { get; set; }

        public string Titulo { get; set; }

        public string SubTitulo { get; set; }

        public string Conteudo { get; set; }

        public DateTime DataPublicacao { get; set; }

        public string DetalheImagem { get; set; }

        public string Imagem { get; set; }

        public int CidadeId { get; set; }

        public int CategoriaId { get; set; }

        public int? Ativo { get; set; }

    }
}