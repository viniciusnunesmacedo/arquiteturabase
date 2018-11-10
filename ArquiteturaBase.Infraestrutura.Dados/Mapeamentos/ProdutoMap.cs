using ArquiteturaBase.Dominio.Modelos;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ArquiteturaBase.Infraestrutura.Dados.Mapeamentos
{
    public class ProdutoMap : IEntityTypeConfiguration<Produto>
    {
        public void Configure(EntityTypeBuilder<Produto> construtor)
        {
            construtor.ToTable("Produto");
            construtor.HasKey(x => x.Id);

            construtor.Property(x => x.Id).HasColumnName(@"Id").HasColumnType("int").IsRequired().UseSqlServerIdentityColumn();
            construtor.Property(x => x.Categoria).HasColumnName(@"Categoria").HasColumnType("nvarchar(max)");
            construtor.Property(x => x.Tamanho).HasColumnName(@"Tamanho").HasColumnType("nvarchar(max)");
            construtor.Property(x => x.Preco).HasColumnName(@"Preco").HasColumnType("decimal").IsRequired();
            construtor.Property(x => x.Titulo).HasColumnName(@"Titulo").HasColumnType("nvarchar(max)");
            construtor.Property(x => x.ArteDescricao).HasColumnName(@"ArteDescricao").HasColumnType("nvarchar(max)");
            construtor.Property(x => x.ArteData).HasColumnName(@"ArteData").HasColumnType("nvarchar(max)");
            construtor.Property(x => x.ArteCodigo).HasColumnName(@"ArteCodigo").HasColumnType("nvarchar(max)");
            construtor.Property(x => x.Artista).HasColumnName(@"Artista").HasColumnType("nvarchar(max)");
            construtor.Property(x => x.ArtistaNascimento).HasColumnName(@"ArtistaNascimento").HasColumnType("datetime2").IsRequired();
            construtor.Property(x => x.ArtistaMorte).HasColumnName(@"ArtistaMorte").HasColumnType("datetime2").IsRequired();
            construtor.Property(x => x.ArtistaNacionalidade).HasColumnName(@"ArtistaNacionalidade").HasColumnType("nvarchar(max)");
        }
    }
}
