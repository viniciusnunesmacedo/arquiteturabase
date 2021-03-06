// <auto-generated>
// ReSharper disable ConvertPropertyToExpressionBody
// ReSharper disable DoNotCallOverridableMethodsInConstructor
// ReSharper disable EmptyNamespace
// ReSharper disable InconsistentNaming
// ReSharper disable PartialMethodWithSinglePart
// ReSharper disable PartialTypeWithSinglePart
// ReSharper disable RedundantNameQualifier
// ReSharper disable RedundantOverridenMember
// ReSharper disable UseNameofExpression
// TargetFrameworkVersion = 4.6
#pragma warning disable 1591    //  Ignore "Missing XML Comment" warning


namespace ArquiteturaBase.Gerador
{

    // Perfil
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.2.0")]
    public class PerfilConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Perfil>
    {
        public PerfilConfiguration()
            : this("dbo")
        {
        }

        public PerfilConfiguration(string schema)
        {
            ToTable("Perfil", schema);
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName(@"Id").HasColumnType("nvarchar").IsRequired().HasMaxLength(450).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Nome).HasColumnName(@"Nome").HasColumnType("nvarchar").IsOptional().HasMaxLength(256);
            Property(x => x.NomeNormalizado).HasColumnName(@"NomeNormalizado").HasColumnType("nvarchar").IsOptional().HasMaxLength(256);
            Property(x => x.ChaveAlteracao).HasColumnName(@"ChaveAlteracao").HasColumnType("nvarchar(max)").IsOptional();
            HasMany(t => t.Usuarios).WithMany(t => t.Perfils).Map(m =>
            {
                m.ToTable("UsuarioPerfil", "dbo");
                m.MapLeftKey("PerfilId");
                m.MapRightKey("UsuarioId");
            });
        }
    }

}
// </auto-generated>
