using Dapper;
using Dominio.Entidade;
using System.Linq;

namespace Infraestrutura.Repositorio
{
    public class ExemplarRepositorio : RepositorioBase
    {
        public ExemplarDominio Criar(ExemplarDominio exemplar)
        {
            var comando = @"
                insert 
                    into Exemplar (IdTipoExemplar, IdAutor, IdEditora, Titulo, Subtitulo)
                    values (@idTipoExemplar, @idAutor, @idEditora, @titulo, @subtitulo)

                select Id, IdTipoExemplar, IdAutor, IdEditora, Titulo, Subtitulo from Exemplar WHERE ID = CAST(SCOPE_IDENTITY() as INT)
            ";

            _connection.Open();
            var novoExemplar = _connection.Query<ExemplarDominio>(comando).FirstOrDefault();

            return novoExemplar;
        }
    }
}
