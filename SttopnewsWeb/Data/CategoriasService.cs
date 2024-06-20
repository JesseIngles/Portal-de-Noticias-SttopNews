global using SttopnewsWeb.Interfaces;
namespace SttopnewsWeb.Data
{
    public class CategoriasService : ICategoria
    {
        //Variavies para Consumir a Api
        HttpClient client = new HttpClient();
        HttpResponseMessage response;

        Task<bool> ICategoria.CadastrarCategoria(string categoria)
        {
            throw new NotImplementedException();
        }

        Task<bool> ICategoria.DeletarCategoria(int id)
        {
            throw new NotImplementedException();
        }

        Task<bool> ICategoria.EditarCategoria(string categoria, int id)
        {
            throw new NotImplementedException();
        }

        Task<Categorias> ICategoria.ListarCategoria(int id)
        {
            throw new NotImplementedException();
        }

        Task<List<Categorias>> ICategoria.listarCategorias()
        {
            throw new NotImplementedException();
        }
    }
}
