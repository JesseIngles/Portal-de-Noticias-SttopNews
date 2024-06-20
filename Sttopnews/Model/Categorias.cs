namespace sttopnews.Models
{
    public class Categorias
    {
        public Categorias() { }
        public int Id { get; set; }
        public string Categoria { get; set;} = string.Empty;

        //Variavies para Consumir a Api
        HttpClient client = new HttpClient();
        HttpResponseMessage response;

        public Task<bool> CadastrarCategoria(string categoria)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeletarCategoria(int id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> EditarCategoria(string categoria, int id)
        {
            throw new NotImplementedException();
        }

        public Task<Categorias> ListarCategoria(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<Categorias>> listarCategorias()
        {
            throw new NotImplementedException();
        }
    }
}
