using Aplicacao.Dto.Exemplar;
using Dominio.Entidade;
using Infraestrutura.Repositorio;

namespace Aplicacao.Servico
{
    public class ExemplarServico
    {
        public ExemplarDto Criar(ExemplarEnvioDto exemplar)
        {
            var repositorio = new ExemplarRepositorio();
            var novoExemplar = repositorio.Criar(
                new ExemplarDominio(exemplar.IdTipoExemplar, exemplar.IdAutor, exemplar.IdEditora, exemplar.Titulo, exemplar.Subtitulo)
            );

            var novoDto = new ExemplarDto
            {
                IdAutor = novoExemplar.IdAutor,
                IdEditora = novoExemplar.IdEditora,
                IdTipoExemplar = novoExemplar.IdTipoExemplar,
                Titulo = novoExemplar.Titulo,
                Subtitulo = novoExemplar.Subtitulo
            };

            return novoDto;
        }
    }
}
