using System.Runtime.InteropServices;
using System.Security.Cryptography.Xml;

namespace sttopnews.Models
{
    public class Noticias
    {
        public int Id { get; set; }
        public string Titulo { get; set; } = string.Empty;
        public string Corpo { get; set; } = string.Empty;
        public string Imagem { get; set; } = string.Empty;
        public DateTime Data { get; set; }
        public bool Status { get; set; } = false;
        public string Redactor { get; set; } = string.Empty;
        public List<NoticiaComentarios> Comentarios { get; set; } = null;
        public string Categoria { get; set; }
        public bool Salvo { get; set;} = false;

        //Variavies para Consumir a Api
        HttpClient client = new HttpClient();
        HttpResponseMessage response;

        /* MÉTODOS A SEREM EXECUTADOS NA CLASSE DAS NOTÍCIAS*/
        public Task<Noticias> CarregarNoticia(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<Noticias>> CarregarNoticias()
        {
            throw new NotImplementedException();
        }


       
    }
}
