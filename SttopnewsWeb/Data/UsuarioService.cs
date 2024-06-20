using SttopnewsWeb.Interfaces;
namespace SttopnewsWeb.Data
{
    public class UsuarioService : IUsuario
    {
        //Variavies para Consumir a Api
        HttpClient client = new HttpClient();
        HttpResponseMessage response;

        // MÉTODOS PARA TODOS OS USUÁRIOS DO SISTEMA
        Task<string> IUsuario.CriarConta(Usuario user)
        {
            throw new NotImplementedException();
        }

        Task<Usuario> IUsuario.FazerLogin(Usuario user)
        {
            throw new NotImplementedException();
        }

        Task<bool> IUsuario.FazerLogOut(string telefone, bool status)
        {
            throw new NotImplementedException();
        }
    }
}
