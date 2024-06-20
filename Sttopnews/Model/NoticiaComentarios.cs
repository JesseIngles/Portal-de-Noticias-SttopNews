namespace sttopnews.Models
{
    public class NoticiaComentarios
    {
        public int Id { get; set; }
        public string Comentario { get; set; } = string.Empty;
        public int Noticia { get; set; }
        public string Leitor { get; set; } = string.Empty;
        public DateTime Data { get; set; }
        public bool Status { get; set; } = false;

        //Variavies para Consumir a Api
        HttpClient client = new HttpClient();
        HttpResponseMessage response;

        /*MÉTODOS DA CLASSE COMENTÁRIOS*/
        public Task<List<NoticiaComentarios>> CarregarComentarios(int id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> ExcluirComentario(int id)
        {
            throw new NotImplementedException();
        }
    }
}
