using ArquiteturaBase.Aplicacao.Interfaces;
using ArquiteturaBase.Aplicacao.Servicos;
using ArquiteturaBase.Dominio.Interfaces;
using ArquiteturaBase.Dominio.Interfaces.Repositorios;
using ArquiteturaBase.Infraestrutura.Dados.Implementacoes;
using ArquiteturaBase.Infraestrutura.Dados.Interfaces;
using ArquiteturaBase.Infraestrutura.Dados.Repositorios;
using ArquiteturaBase.Infraestrutura.Transversal.Identidade.Modelos;
using ArquiteturaBase.Infraestrutura.Transversal.Identidade.Servicos;
using Autofac;
using Autofac.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace ArquiteturaBase.Infraestrutura.Transversal.InversaoControle
{
    public class AutoFacInjetor
    {
        public static IServiceProvider RegistrarServicos(IServiceCollection servicos)
        {
            // ASP.NET HttpContext dependency
            servicos.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();


            //Now register our services with Autofac container
            var construtor = new ContainerBuilder();



            //Aplicação
            construtor.RegisterType<ProdutoAplicacaoServico>().As<IProdutoAplicacaoServico>();

            //Repositório
            construtor.RegisterType<ProdutoRepositorio>().As<IProdutoRepositorio>();

            //Infraestrutura - Data
            construtor.RegisterType<UnidateTrabalho>().As<IUnidadeTrabalho>();
            construtor.RegisterType<FabricaBaseDados>().As<IFabricaBaseDados>();

            //Infraestrutura - Serviços Identidade
            construtor.RegisterType<MensagemRemetenteEmail>().As<IRemetenteEmail>();
            construtor.RegisterType<MensagemRemetenteSms>().As<IRemetenteSms>();

            //Infraestrutura - Identidade
            construtor.RegisterType<Usuario>().As<IUsuario>();

            construtor.Populate(servicos);

            var container = construtor.Build();

            //Create the IServiceProvider based on the container.
            return new AutofacServiceProvider(container);
        }
    }
}
