namespace SttopnewsWeb.Data
{
    public class NoticiaComentarios
    {
        public int Id { get; set; }
        public string Comentario { get; set; } = string.Empty;
        public int Noticia { get; set; }
        public string Leitor { get; set; } = string.Empty;
        public DateTime Data { get; set; }
        public bool Status { get; set; } = false;
    }
}
