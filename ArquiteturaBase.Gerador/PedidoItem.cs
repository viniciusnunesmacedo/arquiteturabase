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

    // PedidoItem
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.2.0")]
    public class PedidoItem
    {
        public int Id { get; set; } // Id (Primary key)
        public int? ProdutoId { get; set; } // ProdutoId
        public int Quantidade { get; set; } // Quantidade
        public decimal PrecoUnitario { get; set; } // PrecoUnitario
        public int? PedidoId { get; set; } // PedidoId

        // Foreign keys

        /// <summary>
        /// Parent Pedido pointed by [PedidoItem].([PedidoId]) (FK_PedidoItem_Pedido_PedidoId)
        /// </summary>
        public virtual Pedido Pedido { get; set; } // FK_PedidoItem_Pedido_PedidoId

        /// <summary>
        /// Parent Produto pointed by [PedidoItem].([ProdutoId]) (FK_PedidoItem_Produto_ProdutoId)
        /// </summary>
        public virtual Produto Produto { get; set; } // FK_PedidoItem_Produto_ProdutoId
    }

}
// </auto-generated>
