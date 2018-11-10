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

    // Usuario
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.2.0")]
    public class UsuarioConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Usuario>
    {
        public UsuarioConfiguration()
            : this("dbo")
        {
        }

        public UsuarioConfiguration(string schema)
        {
            ToTable("Usuario", schema);
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName(@"Id").HasColumnType("nvarchar").IsRequired().HasMaxLength(450).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.NomeUsuario).HasColumnName(@"NomeUsuario").HasColumnType("nvarchar").IsOptional().HasMaxLength(256);
            Property(x => x.NomeUsuarioNormalizado).HasColumnName(@"NomeUsuarioNormalizado").HasColumnType("nvarchar").IsOptional().HasMaxLength(256);
            Property(x => x.Email).HasColumnName(@"Email").HasColumnType("nvarchar").IsOptional().HasMaxLength(256);
            Property(x => x.EmailNormalizado).HasColumnName(@"EmailNormalizado").HasColumnType("nvarchar").IsOptional().HasMaxLength(256);
            Property(x => x.EmailConfirmado).HasColumnName(@"EmailConfirmado").HasColumnType("bit").IsRequired();
            Property(x => x.Senha).HasColumnName(@"Senha").HasColumnType("nvarchar(max)").IsOptional();
            Property(x => x.ChaveSenha).HasColumnName(@"ChaveSenha").HasColumnType("nvarchar(max)").IsOptional();
            Property(x => x.ChaveAlteracao).HasColumnName(@"ChaveAlteracao").HasColumnType("nvarchar(max)").IsOptional();
            Property(x => x.Telefone).HasColumnName(@"Telefone").HasColumnType("nvarchar(max)").IsOptional();
            Property(x => x.TelefoneConfirmado).HasColumnName(@"TelefoneConfirmado").HasColumnType("bit").IsRequired();
            Property(x => x.DoisFatoresAtivado).HasColumnName(@"DoisFatoresAtivado").HasColumnType("bit").IsRequired();
            Property(x => x.Saida).HasColumnName(@"Saida").HasColumnType("datetimeoffset").IsOptional();
            Property(x => x.PodeSair).HasColumnName(@"PodeSair").HasColumnType("bit").IsRequired();
            Property(x => x.QuantidadeFalhas).HasColumnName(@"QuantidadeFalhas").HasColumnType("int").IsRequired();
        }
    }

}
// </auto-generated>