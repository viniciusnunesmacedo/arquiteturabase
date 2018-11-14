namespace ArquiteturaBase.Dominio.Modelos
{
    public class PedidoItem
    {
        public int Id { get; set; } 
        public int? ProdutoId { get; set; }
        public int Quantidade { get; set; }
        public decimal PrecoUnitario { get; set; }
        public int? PedidoId { get; set; }

        // Chaves Estrangeiras
        public virtual Pedido Pedido { get; set; }

        public virtual Produto Produto { get; set; }
    }
}
