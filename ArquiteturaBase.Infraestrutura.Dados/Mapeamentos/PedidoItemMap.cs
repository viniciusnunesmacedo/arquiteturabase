using ArquiteturaBase.Dominio.Modelos;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ArquiteturaBase.Infraestrutura.Dados.Mapeamentos
{
    public class PedidoItemMap : IEntityTypeConfiguration<PedidoItem>
    {
        public void Configure(EntityTypeBuilder<PedidoItem> construtor)
        {
            construtor.ToTable("PedidoItem");
            construtor.HasKey(x => x.Id);

            construtor.Property(x => x.Id).HasColumnName(@"Id").HasColumnType("int").IsRequired().UseSqlServerIdentityColumn();
            construtor.Property(x => x.ProdutoId).HasColumnName(@"ProdutoId").HasColumnType("int");
            construtor.Property(x => x.Quantidade).HasColumnName(@"Quantidade").HasColumnType("int").IsRequired();
            construtor.Property(x => x.PrecoUnitario).HasColumnName(@"PrecoUnitario").HasColumnType("decimal").IsRequired();
            construtor.Property(x => x.PedidoId).HasColumnName(@"PedidoId").HasColumnType("int");

            // chaves estrangeiras
            construtor.HasOne(a => a.Pedido).WithMany(b => b.PedidoItens).HasForeignKey(c => c.PedidoId).OnDelete(DeleteBehavior.SetNull);
            construtor.HasOne(a => a.Produto).WithMany(b => b.PedidoItens).HasForeignKey(c => c.ProdutoId).OnDelete(DeleteBehavior.SetNull);
        }
    }
}
