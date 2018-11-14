using ArquiteturaBase.Aplicacao.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ArquiteturaBase.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProdutoController : ApiController
    {
        private readonly IProdutoAplicacaoServico _produtoAplicacaoServico;

        public ProdutoController(IProdutoAplicacaoServico produtoAplicacaoServico)
        {
            _produtoAplicacaoServico = produtoAplicacaoServico;
        }

        [HttpGet]
        //[AllowAnonymous]
        //[Route("produtos")]
        public IActionResult Get()
        {
            return Ok(_produtoAplicacaoServico.BuscarTodos());
        }
    }
}
