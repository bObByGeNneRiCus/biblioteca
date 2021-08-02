using Aplicacao.Dto.Exemplar;
using Aplicacao.Servico;
using Microsoft.AspNetCore.Mvc;

namespace ApiBiblioteca.Controllers
{
    [ApiController]
    [Route("exemplares")]
    public class ExemplarController : ControllerBase
    {
        [HttpPost]
        public ExemplarDto Criar([FromBody] ExemplarEnvioDto exemplar)
        {
            var servico = new ExemplarServico();

            var novoExemplar = servico.Criar(exemplar);

            return novoExemplar;
        }
    }
}
