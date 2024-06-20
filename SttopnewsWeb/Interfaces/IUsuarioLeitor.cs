namespace SttopnewsWeb.Interfaces
{
    public interface IUsuarioLeitor : IUsuario, INoticiaComentario
    {
        public Task<bool> ComentarNoticia(int id);
        public Task<bool> EditarComentário(int id);        
    }
}