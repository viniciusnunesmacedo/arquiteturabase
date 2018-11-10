using ArquiteturaBase.Aplicacao.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace ArquiteturaBase.WebApi.Controllers
{
    public class ProdutoController : ApiController
    {
        private readonly IProdutoAplicacaoServico _produtoAplicacaoServico;

        public ProdutoController(IProdutoAplicacaoServico produtoAplicacaoServico)
        {
            _produtoAplicacaoServico = produtoAplicacaoServico;
        }

        [HttpGet]
        //[AllowAnonymous]
        //[Route("customer-management")]
        public IActionResult Get()
        {
            return Ok(_produtoAplicacaoServico.BuscarTodos());
        }
    }
}
