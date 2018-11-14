using System;
using System.Collections.Generic;

namespace ArquiteturaBase.Dominio.Modelos
{
    public class Pedido
    {
        public int Id { get; set; }
        public DateTime DataPedido { get; set; }
        public string NumeroPedido { get; set; }
        public string UsuarioId { get; set; }

        // Navegação Reversa
        public virtual ICollection<PedidoItem> PedidoItens { get; set; }
    }
}
