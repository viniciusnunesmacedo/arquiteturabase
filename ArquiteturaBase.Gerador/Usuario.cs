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
    public class Usuario
    {
        public string Id { get; set; } // Id (Primary key) (length: 450)
        public string NomeUsuario { get; set; } // NomeUsuario (length: 256)
        public string NomeUsuarioNormalizado { get; set; } // NomeUsuarioNormalizado (length: 256)
        public string Email { get; set; } // Email (length: 256)
        public string EmailNormalizado { get; set; } // EmailNormalizado (length: 256)
        public bool EmailConfirmado { get; set; } // EmailConfirmado
        public string Senha { get; set; } // Senha
        public string ChaveSenha { get; set; } // ChaveSenha
        public string ChaveAlteracao { get; set; } // ChaveAlteracao
        public string Telefone { get; set; } // Telefone
        public bool TelefoneConfirmado { get; set; } // TelefoneConfirmado
        public bool DoisFatoresAtivado { get; set; } // DoisFatoresAtivado
        public System.DateTimeOffset? Saida { get; set; } // Saida
        public bool PodeSair { get; set; } // PodeSair
        public int QuantidadeFalhas { get; set; } // QuantidadeFalhas

        // Reverse navigation

        /// <summary>
        /// Child Perfils (Many-to-Many) mapped by table [UsuarioPerfil]
        /// </summary>
        public virtual System.Collections.Generic.ICollection<Perfil> Perfils { get; set; } // Many to many mapping
        /// <summary>
        /// Child UsuarioAtributoes where [UsuarioAtributo].[UsuarioId] point to this entity (FK_UsuarioAtributo_Usuario_UsuarioId)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<UsuarioAtributo> UsuarioAtributoes { get; set; } // UsuarioAtributo.FK_UsuarioAtributo_Usuario_UsuarioId
        /// <summary>
        /// Child UsuarioProvedors where [UsuarioProvedor].[UsuarioId] point to this entity (FK_UsuarioProvedor_Usuario_UsuarioId)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<UsuarioProvedor> UsuarioProvedors { get; set; } // UsuarioProvedor.FK_UsuarioProvedor_Usuario_UsuarioId
        /// <summary>
        /// Child UsuarioProvedorLogins where [UsuarioProvedorLogin].[UsuarioId] point to this entity (FK_UsuarioProvedorLogin_Usuario_UsuarioId)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<UsuarioProvedorLogin> UsuarioProvedorLogins { get; set; } // UsuarioProvedorLogin.FK_UsuarioProvedorLogin_Usuario_UsuarioId

        public Usuario()
        {
            UsuarioAtributoes = new System.Collections.Generic.List<UsuarioAtributo>();
            UsuarioProvedors = new System.Collections.Generic.List<UsuarioProvedor>();
            UsuarioProvedorLogins = new System.Collections.Generic.List<UsuarioProvedorLogin>();
            Perfils = new System.Collections.Generic.List<Perfil>();
        }
    }

}
// </auto-generated>
