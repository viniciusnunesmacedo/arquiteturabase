using System;

namespace ArquiteturaBase.Aplicacao.ModelosTela
{
    public class ProdutoModeloTela
    {
        public int Id { get; set; }
        public string Categoria { get; set; }
        public string Tamanho { get; set; }
        public decimal Preco { get; set; }
        public string Titulo { get; set; }
        public string ArteDescricao { get; set; }
        public string ArteData { get; set; }
        public string ArteCodigo { get; set; }
        public string Artista { get; set; }
        public DateTime ArtistaNascimento { get; set; }
        public DateTime ArtistaMorte { get; set; }
        public string ArtistaNacionalidade { get; set; }
    }
}
