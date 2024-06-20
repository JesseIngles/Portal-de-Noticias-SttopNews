using SttopnewsWeb.Data;

namespace SttopnewsWeb.Interfaces
{
    public interface IUsuarioAdmin : INoticiaComentario, IUsuarioRedactor
    {
        public Task<List<UsuarioRedactor>> ListaRedactores();
        public Task<string> PermitirCadastro(string telefone);
        public Task<bool> TornarAdmin(string telefone);
        public  Task<bool> RemoverRedactor(string telefone);
        public  Task<bool> ValidarNoticia(int id, bool status);
        public Task<bool> RemoverNoticia(int id);
        public Task<string> GerirPermissoes(string telefone, bool status);
    }
}
