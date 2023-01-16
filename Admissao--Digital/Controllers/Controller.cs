using Admissao__Digital.application.Mapper;
using Admissao__Digital.application.ViewModel;
using Admissao__Digital.Core.Entidades;
using Admissao__Digital.Core.Interface.Services;
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
        private readonly IContratadoService _contratadoService;
        private readonly IValidadorFotosService _validadorFotosService;

        public Controller(ILogger<Controller> logger, IContratadoService contratadoService, IValidadorFotosService validadorFotosService)
        {
            _logger = logger;
            _contratadoService = contratadoService;
            _validadorFotosService = validadorFotosService;
        }
       

        [HttpPost]
        [Route("Contratado")]
        public IActionResult Inserir([FromBody] CriarUsuarioViewModel criarUsuarioViewModel)
        {
            var criarUsuario = CriarUsuarioMapper.ToCriarUsuarioEntity(criarUsuarioViewModel);

            _contratadoService.CriarUsuario(criarUsuario);

            return Ok("Usuário criado com sucesso");
        }

        [HttpGet]
        [Route("Consultar")]
        public IActionResult Consultar()
        {
            var retornoImagem64 = _validadorFotosService.ConverterImagemBase64();

            return Ok(retornoImagem64);
        }
    }
}