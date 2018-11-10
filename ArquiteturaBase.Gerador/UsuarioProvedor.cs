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

    // UsuarioProvedor
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.2.0")]
    public class UsuarioProvedor
    {
        public string UsuarioId { get; set; } // UsuarioId (Primary key) (length: 450)
        public string LoginProvedor { get; set; } // LoginProvedor (Primary key) (length: 450)
        public string Nome { get; set; } // Nome (Primary key) (length: 450)
        public string Valor { get; set; } // Valor

        // Foreign keys

        /// <summary>
        /// Parent Usuario pointed by [UsuarioProvedor].([UsuarioId]) (FK_UsuarioProvedor_Usuario_UsuarioId)
        /// </summary>
        public virtual Usuario Usuario { get; set; } // FK_UsuarioProvedor_Usuario_UsuarioId
    }

}
// </auto-generated>
