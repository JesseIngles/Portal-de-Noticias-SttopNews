using SttopnewsWeb.Interfaces;
using System.Runtime.InteropServices;
using System.Security.Cryptography.Xml;
namespace SttopnewsWeb.Data
{
    public class Noticias : INoticia
    {
        public int Id { get; set; }
        public string Titulo { get; set; } = string.Empty;
        public string Corpo { get; set; } = string.Empty;
        public string Imagem { get; set; } = string.Empty;
        public DateTime Data { get; set; }
        public bool Status { get; set; } = false;
        public string Redactor { get; set; } = string.Empty;
        public List<NoticiaComentarios> Comentarios { get; set; } = null;
        public int Categoria { get; set; }

        //Variavies para Consumir a Api
        HttpClient client = new HttpClient();
        HttpResponseMessage response;

        /* MÉTODOS A SEREM EXECUTADOS NA CLASSE DAS NOTÍCIAS*/
        Task<Noticias> INoticia.CarregarNoticia(int id)
        {
            throw new NotImplementedException();
        }

        Task<List<Noticias>> INoticia.CarregarNoticias()
        {
            throw new NotImplementedException();
        }


       
    }
}
