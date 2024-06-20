using SttopnewsWeb.Data;

namespace SttopnewsWeb.Interfaces
{
    public interface IUsuario 
    {
        public Task<string> CriarConta(Usuario user);
        //MÉTODO PARA FAZER O LOGIN ...
        public Task<Usuario> FazerLogin(Usuario user);
        //MÉTODO PARA TERMINAR SESSÃO ...
        public Task<bool> FazerLogOut(string telefone, bool status);
    }
}