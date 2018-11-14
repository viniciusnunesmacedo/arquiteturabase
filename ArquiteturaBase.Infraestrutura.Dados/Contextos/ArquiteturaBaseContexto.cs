using ArquiteturaBase.Infraestrutura.Dados.Mapeamentos;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace ArquiteturaBase.Infraestrutura.Dados.Contextos
{
    public class ArquiteturaBaseContexto : DbContext
    {
        protected override void OnModelCreating(ModelBuilder construtorModelo)
        {
            construtorModelo.ApplyConfiguration(new PedidoMap());
            construtorModelo.ApplyConfiguration(new PedidoItemMap());
            construtorModelo.ApplyConfiguration(new ProdutoMap());

            base.OnModelCreating(construtorModelo);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder opcoesConstrutor)
        {
            // get the configuration from the app settings
            var config = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            // define the database to use
            opcoesConstrutor.UseSqlServer(config.GetConnectionString("ConexaoPadrao"));
        }
    }
}
