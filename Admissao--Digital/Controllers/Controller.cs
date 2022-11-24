using Admissao__Digital.application.Model;
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
        public IActionResult Inserir([FromBody] ModelCriarUsuario modelCriarUsuario)
        {            
            _gerenciadorJsonContratado.CriarUsuario(modelCriarUsuario);
            return Ok("Usuário criado com sucesso");
        }
    }
}