using System.ComponentModel;
using System.Data;
using System.Reflection.Metadata.Ecma335;
using System.Threading.Tasks;

namespace sttopnews.Models
{
    public class Usuario
    {
        // ATRIBUTOS PARA TODOS OS USUÁRIOS DO SISTEMA
        public int Id { get; set; }
        public string Tipo { get; set; } = string.Empty;
        public string Nome { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Telefone { get; set; } = string.Empty;
        public string Senha { get; set; } = string.Empty;
        public string Cadastrado { get; set; } = string.Empty;
        public string Admin { get; set; } = string.Empty;
        public bool Status { get; set; } = false;
        public bool Logado { get; set; } = false;
        public string Msn { get; set; } = string.Empty;
        string resposta = string.Empty;

        //Variavies para Consumir a Api
        HttpClient client = new HttpClient();
        HttpResponseMessage response;

        // MÉTODOS PARA TODOS OS USUÁRIOS DO SISTEMA
        public Task<string> CriarConta(Usuario user)
        {
            throw new NotImplementedException();
        }

        public Task<Usuario> FazerLogin(Usuario user)
        {
            throw new NotImplementedException();
        }

        public Task<bool> FazerLogOut(string telefone, bool status)
        {
            throw new NotImplementedException();
        }

        



    }
}