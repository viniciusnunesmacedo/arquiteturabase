using ArquiteturaBase.Dominio.Modelos;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ArquiteturaBase.Infraestrutura.Dados.Mapeamentos
{
    public class PedidoMap : IEntityTypeConfiguration<Pedido>
    {
        public void Configure(EntityTypeBuilder<Pedido> construtor)
        {
            construtor.ToTable("Pedido");
            construtor.HasKey(x => x.Id);

            construtor.Property(x => x.Id).HasColumnName(@"Id").HasColumnType("int").IsRequired().UseSqlServerIdentityColumn();
            construtor.Property(x => x.DataPedido).HasColumnName(@"DataPedido").HasColumnType("datetime2");
            construtor.Property(x => x.NumeroPedido).HasColumnName(@"NumeroPedido").HasColumnType("nvarchar(max)");
            construtor.Property(x => x.UsuarioId).HasColumnName(@"UsuarioId").HasColumnType("nvarchar").HasMaxLength(450);

            // Chaves estrangeiras
            //construtor.HasOne(a => a.).WithMany(b => b.Pedidos).HasForeignKey(c => c.PedidoId).OnDelete(DeleteBehavior.SetNull);
        }
    }
}
