using ArquiteturaBase.Infraestrutura.Transversal.Identidade.Modelos;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace ArquiteturaBase.Infraestrutura.Transversal.Identidade.Dados
{
    public class ArquiteturaBaseContextoBaseDados : IdentityDbContext<UsuarioAplicacao>
    {
        public ArquiteturaBaseContextoBaseDados(DbContextOptions<ArquiteturaBaseContextoBaseDados> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder construtorModelo)
        {
            base.OnModelCreating(construtorModelo);

            //Tabela: IdentityUser => Usuario
            construtorModelo.Entity<UsuarioAplicacao>().ToTable("Usuario").Property(p => p.UserName).HasColumnName("NomeUsuario");
            construtorModelo.Entity<UsuarioAplicacao>().ToTable("Usuario").Property(p => p.NormalizedUserName).HasColumnName("NomeUsuarioNormalizado");
            construtorModelo.Entity<UsuarioAplicacao>().ToTable("Usuario").Property(p => p.Email).HasColumnName("Email");
            construtorModelo.Entity<UsuarioAplicacao>().ToTable("Usuario").Property(p => p.NormalizedEmail).HasColumnName("EmailNormalizado");
            construtorModelo.Entity<UsuarioAplicacao>().ToTable("Usuario").Property(p => p.EmailConfirmed).HasColumnName("EmailConfirmado");
            construtorModelo.Entity<UsuarioAplicacao>().ToTable("Usuario").Property(p => p.PasswordHash).HasColumnName("Senha");
            construtorModelo.Entity<UsuarioAplicacao>().ToTable("Usuario").Property(p => p.SecurityStamp).HasColumnName("ChaveSenha");
            construtorModelo.Entity<UsuarioAplicacao>().ToTable("Usuario").Property(p => p.ConcurrencyStamp).HasColumnName("ChaveAlteracao");
            construtorModelo.Entity<UsuarioAplicacao>().ToTable("Usuario").Property(p => p.PhoneNumber).HasColumnName("Telefone");
            construtorModelo.Entity<UsuarioAplicacao>().ToTable("Usuario").Property(p => p.PhoneNumberConfirmed).HasColumnName("TelefoneConfirmado");
            construtorModelo.Entity<UsuarioAplicacao>().ToTable("Usuario").Property(p => p.TwoFactorEnabled).HasColumnName("DoisFatoresAtivado");
            construtorModelo.Entity<UsuarioAplicacao>().ToTable("Usuario").Property(p => p.LockoutEnd).HasColumnName("Saida");
            construtorModelo.Entity<UsuarioAplicacao>().ToTable("Usuario").Property(p => p.LockoutEnabled).HasColumnName("PodeSair");
            construtorModelo.Entity<UsuarioAplicacao>().ToTable("Usuario").Property(p => p.AccessFailedCount).HasColumnName("QuantidadeFalhas");

            //Tabela: IdentityUserToken => UsuarioProvedor
            construtorModelo.Entity<IdentityUserToken<string>>().ToTable("UsuarioProvedor").Property(p => p.UserId).HasColumnName("UsuarioId");
            construtorModelo.Entity<IdentityUserToken<string>>().ToTable("UsuarioProvedor").Property(p => p.LoginProvider).HasColumnName("LoginProvedor");
            construtorModelo.Entity<IdentityUserToken<string>>().ToTable("UsuarioProvedor").Property(p => p.Name).HasColumnName("Nome");
            construtorModelo.Entity<IdentityUserToken<string>>().ToTable("UsuarioProvedor").Property(p => p.Value).HasColumnName("Valor");

            //Tabela: IdentityUserRole => UsuarioPerfil
            construtorModelo.Entity<IdentityUserRole<string>>().ToTable("UsuarioPerfil").Property(p => p.UserId).HasColumnName("UsuarioId");
            construtorModelo.Entity<IdentityUserRole<string>>().ToTable("UsuarioPerfil").Property(p => p.RoleId).HasColumnName("PerfilId");

            //Tabela: IdentityUserLogin => UsuarioProvedorLogin
            construtorModelo.Entity<IdentityUserLogin<string>>().ToTable("UsuarioProvedorLogin").Property(p => p.LoginProvider).HasColumnName("LoginProvedor");
            construtorModelo.Entity<IdentityUserLogin<string>>().ToTable("UsuarioProvedorLogin").Property(p => p.ProviderKey).HasColumnName("ChaveProvedor");
            construtorModelo.Entity<IdentityUserLogin<string>>().ToTable("UsuarioProvedorLogin").Property(p => p.ProviderDisplayName).HasColumnName("NomeProvedor");
            construtorModelo.Entity<IdentityUserLogin<string>>().ToTable("UsuarioProvedorLogin").Property(p => p.UserId).HasColumnName("UsuarioId");

            //Tabela: IdentityUserClaims => UsuarioAtributo
            construtorModelo.Entity<IdentityUserClaim<string>>().ToTable("UsuarioAtributo").Property(p => p.UserId).HasColumnName("UsuarioId");
            construtorModelo.Entity<IdentityUserClaim<string>>().ToTable("UsuarioAtributo").Property(p => p.ClaimType).HasColumnName("TipoAtributo");
            construtorModelo.Entity<IdentityUserClaim<string>>().ToTable("UsuarioAtributo").Property(p => p.ClaimValue).HasColumnName("ValorAtributo");

            //Tabela: IdentityRole => Perfil
            construtorModelo.Entity<IdentityRole>().ToTable("Perfil").Property(p => p.Name).HasColumnName("Nome");
            construtorModelo.Entity<IdentityRole>().ToTable("Perfil").Property(p => p.NormalizedName).HasColumnName("NomeNormalizado");
            construtorModelo.Entity<IdentityRole>().ToTable("Perfil").Property(p => p.ConcurrencyStamp).HasColumnName("ChaveAlteracao");

            //Tabela: IdentityRoleClaim => PerfilAtributo
            construtorModelo.Entity<IdentityRoleClaim<string>>().ToTable("PerfilAtributo").Property(p => p.RoleId).HasColumnName("PerfilId");
            construtorModelo.Entity<IdentityRoleClaim<string>>().ToTable("PerfilAtributo").Property(p => p.ClaimType).HasColumnName("TipoAtributo");
            construtorModelo.Entity<IdentityRoleClaim<string>>().ToTable("PerfilAtributo").Property(p => p.ClaimValue).HasColumnName("ValorAtributo");
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
