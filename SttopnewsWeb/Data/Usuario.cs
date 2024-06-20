using System.ComponentModel;
using System.Data;
using System.Reflection.Metadata.Ecma335;
using System.Threading.Tasks;
using SttopnewsWeb.Interfaces;

namespace SttopnewsWeb.Data
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

    }
}