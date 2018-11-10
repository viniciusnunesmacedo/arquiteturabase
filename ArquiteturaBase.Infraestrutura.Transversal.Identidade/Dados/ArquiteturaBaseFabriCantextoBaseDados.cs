using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace ArquiteturaBase.Infraestrutura.Transversal.Identidade.Dados
{
    public class ArquiteturaBaseFabriCantextoBaseDados : IDesignTimeDbContextFactory<ArquiteturaBaseContextoBaseDados>
    {
        public ArquiteturaBaseContextoBaseDados CreateDbContext(string[] args)
        {
            // obtem a configuração do app settings
            var config = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            var construtor = new DbContextOptionsBuilder<ArquiteturaBaseContextoBaseDados>();
            construtor.UseSqlServer(config.GetConnectionString("ConexaoPadrao"));

            return new ArquiteturaBaseContextoBaseDados(construtor.Options);
        }
    }
}
