using ArquiteturaBase.Infraestrutura.Dados.Contextos;

namespace ArquiteturaBase.Infraestrutura.Dados.Interfaces
{
    public interface IFabricaBaseDados
    {
        ArquiteturaBaseContexto BuscarContexto();
    }
}
