using SttopnewsWeb.Data;
namespace SttopnewsWeb.Interfaces
{
    public interface INoticiaComentario
    {
        public Task<bool> ExcluirComentario(int id);
        public Task<List<NoticiaComentarios>> CarregarComentarios(int id);
    }
}
