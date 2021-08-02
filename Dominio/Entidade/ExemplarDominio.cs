namespace Dominio.Entidade
{
    public class ExemplarDominio
    {
        public int Id { get; private set; }
        public short IdTipoExemplar { get; private set; }
        public int IdAutor { get; private set; }
        public int IdEditora { get; private set; }
        public string Titulo { get; private set; }
        public string Subtitulo { get; private set; }
        public bool Removido { get; private set; }

        public ExemplarDominio(short idTipoExemplar, int idAutor, int idEditora, string titulo, string subtitulo)
        {
            IdTipoExemplar = idTipoExemplar;
            IdAutor = idAutor;
            IdEditora = idEditora;
            Titulo = titulo;
            Subtitulo = subtitulo;
            Removido = true;
        }

        public void Atualizar(short idTipoExemplar, int idAutor, int idEditora, string titulo, string subtitulo)
        {
            IdTipoExemplar = idTipoExemplar;
            IdAutor = idAutor;
            IdEditora = idEditora;
            Titulo = titulo;
            Subtitulo = subtitulo;
        }

        public void Remover(bool exemplarRemovido)
        {
            Removido = exemplarRemovido;
        }
    }
}
