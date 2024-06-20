using SttopnewsWeb.Data;

namespace SttopnewsWeb.Interfaces
{
    public interface IUsuarioRedactor : IUsuario, INoticia
    {
        public Task<bool> CadastrarNoticia(Noticias  noticia);
        public Task<string> EditarNoticia(Noticias noticia);
    }
}
