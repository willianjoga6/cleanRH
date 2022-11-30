using Admissao__Digital.application.Mapper;
using Admissao__Digital.application.ViewModel;
using Admissao__Digital.Core.Entidades;
using Admissao__Digital.Core.Services;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;


namespace Admissao__Digital.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class Controller : ControllerBase
    {
        private readonly ILogger<Controller> _logger;
        private readonly GerenciadorJsonContratado _gerenciadorJsonContratado;

        public Controller(ILogger<Controller> logger, GerenciadorJsonContratado gerenciadorJsonContratado)
        {
            _logger = logger;
            _gerenciadorJsonContratado = gerenciadorJsonContratado;
        }

        [HttpPost]
        [Route("Contratado")]
        public IActionResult Inserir([FromBody] CriarUsuarioViewModel criarUsuarioViewModel)
        {
            var criarUsuario = CriarUsuarioMapper.ToCriarUsuarioEntity(criarUsuarioViewModel);

            _gerenciadorJsonContratado.CriarUsuario(criarUsuario);

            return Ok("Usuário criado com sucesso");
        }
    }
}