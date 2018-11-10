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

    // UsuarioAtributo
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.2.0")]
    public class UsuarioAtributo
    {
        public int Id { get; set; } // Id (Primary key)
        public string UsuarioId { get; set; } // UsuarioId (length: 450)
        public string TipoAtributo { get; set; } // TipoAtributo
        public string ValorAtributo { get; set; } // ValorAtributo

        // Foreign keys

        /// <summary>
        /// Parent Usuario pointed by [UsuarioAtributo].([UsuarioId]) (FK_UsuarioAtributo_Usuario_UsuarioId)
        /// </summary>
        public virtual Usuario Usuario { get; set; } // FK_UsuarioAtributo_Usuario_UsuarioId
    }

}
// </auto-generated>