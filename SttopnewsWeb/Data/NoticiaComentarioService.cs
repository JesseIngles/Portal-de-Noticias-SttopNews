using SttopnewsWeb.Interfaces;
namespace SttopnewsWeb.Data
{
    public class NoticiaComentarioService : INoticiaComentario
    {
        //Variavies para Consumir a Api
        HttpClient client = new HttpClient();
        HttpResponseMessage response;

        /*MÉTODOS DA CLASSE COMENTÁRIOS*/
        Task<List<NoticiaComentarios>> INoticiaComentario.CarregarComentarios(int id)
        {
            throw new NotImplementedException();
        }

        Task<bool> INoticiaComentario.ExcluirComentario(int id)
        {
            throw new NotImplementedException();
        }
    }
}
