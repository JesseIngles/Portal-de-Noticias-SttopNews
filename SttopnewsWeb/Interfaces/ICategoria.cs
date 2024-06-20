using SttopnewsWeb.Data;
namespace SttopnewsWeb.Interfaces
{
    public interface ICategoria
    {
        public Task<bool> CadastrarCategoria(string categoria);
        public Task<List<Categorias>> listarCategorias();
        public Task<Categorias> ListarCategoria(int id);
        public Task<bool> EditarCategoria(string categoria, int id);
        public Task<bool> DeletarCategoria(int id);
    }
}
