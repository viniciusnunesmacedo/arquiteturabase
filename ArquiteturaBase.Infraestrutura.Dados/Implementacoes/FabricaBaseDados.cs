using ArquiteturaBase.Infraestrutura.Dados.Contextos;
using ArquiteturaBase.Infraestrutura.Dados.Interfaces;

namespace ArquiteturaBase.Infraestrutura.Dados.Implementacoes
{
    public class FabricaBaseDados : Disposable, IFabricaBaseDados
    {
        private ArquiteturaBaseContexto contexto;

        public ArquiteturaBaseContexto BuscarContexto()
        {
            if(contexto != null)
            {
                return contexto;
            }

            contexto = new ArquiteturaBaseContexto();

            return contexto;
        }

        protected override void DisposeCore()
        {
            contexto?.Dispose();
        }
    }
}
