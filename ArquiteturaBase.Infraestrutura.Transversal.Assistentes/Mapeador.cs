using AutoMapper;
using System.Collections.Generic;

namespace ArquiteturaBase.Infraestrutura.Transversal.Assistentes
{
    public static class Mapeador
    {
        public static TDest MapeamentoPara<TDest>(this object src)
        {
            Mapper.Initialize(cfg =>
            {
                cfg.CreateMap(src.GetType(), typeof(TDest));
            });

            return (TDest)Mapper.Map(src, src.GetType(), typeof(TDest));
        }

        public static List<TDest> MapeamentoParaLista<TDest>(this object src)
        {
            if (src != null)
            {
                var type = src.GetType().GetGenericArguments()[0];

                if (type != null)
                {
                    Mapper.Initialize(cfg =>
                    {
                        cfg.CreateMap(type, typeof(TDest));
                    });

                    return Mapper.Map<List<TDest>>(src);
                }
                return null;
            }
            return null;
        }
    }
}
