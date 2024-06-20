
using SttopnewsWeb.Interfaces;

namespace SttopnewsWeb.Data
{
    public class UsuarioLeitor : Usuario
    {
        //Variavies para Consumir a Api
        HttpClient client = new HttpClient();
        HttpResponseMessage response;

        public Task<List<NoticiaComentarios>> CarregarComentarios(int id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> ComentarNoticia(int id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> EditarComentário(int id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> ExcluirComentario(int id)
        {
            throw new NotImplementedException();
        }
    }
}