using SttopnewsWeb.Interfaces;

namespace SttopnewsWeb.Data
{
    public class UsuarioAdmin : UsuarioRedactor, IUsuarioAdmin
    {
        //Variavies para Consumir a Api
        HttpClient client = new HttpClient();
        HttpResponseMessage response;

        public Task<List<NoticiaComentarios>> CarregarComentarios(int id)
        {
            throw new NotImplementedException();
            //response
        }

        public Task<bool> ExcluirComentario(int id)
        {
            throw new NotImplementedException();

        }

        public Task<string> GerirPermissoes(string telefone, bool status)
        {
            throw new NotImplementedException();
        }

        public Task<List<UsuarioRedactor>> ListaRedactores()
        {
            throw new NotImplementedException();
        }

        public Task<string> PermitirCadastro(string telefone)
        {
            throw new NotImplementedException();
        }

        public Task<bool> RemoverNoticia(int id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> RemoverRedactor(string telefone)
        {
            throw new NotImplementedException();
        }

        public Task<bool> TornarAdmin(string telefone)
        {
            throw new NotImplementedException();
        }

        public Task<bool> ValidarNoticia(int id, bool status)
        {
            throw new NotImplementedException();
        }
    }
}