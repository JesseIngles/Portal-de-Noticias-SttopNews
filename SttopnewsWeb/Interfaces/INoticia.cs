using SttopnewsWeb.Data;
namespace SttopnewsWeb.Interfaces
{
    public interface INoticia 
    {
        public Task<List<Noticias>> CarregarNoticias();
        public Task<Noticias> CarregarNoticia(int id);
    }
}
