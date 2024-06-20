using sttopnews.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sttopnews.Controller
{
    public class UsuarioAdminController
    {
        public List<NoticiaComentarios> CarregarComentarios(int id)
        {
            return new UsuarioAdmin().CarregarComentarios(id).Result;
        }

        public bool ExcluirComentario(int id)
        {
            return new UsuarioAdmin().ExcluirComentario(id).Result;
        }

        public string GerirPermissoes(string telefone, bool status)
        {
            return new UsuarioAdmin().GerirPermissoes(telefone, status).Result;
        }

        public List<UsuarioRedactor> ListaRedactores()
        {
            return new UsuarioAdmin().ListaRedactores().Result;
        }

        public string PermitirCadastro(string telefone)
        {
            return new UsuarioAdmin().PermitirCadastro(telefone).Result;
        }

        public bool RemoverNoticia(int id)
        {
            return new UsuarioAdmin().RemoverNoticia(id).Result;
        }

        public bool RemoverRedactor(string telefone)
        {
            return new UsuarioAdmin().RemoverRedactor(telefone).Result;
        }

        public bool TornarAdmin(string telefone)
        {
            return new UsuarioAdmin().TornarAdmin(telefone).Result;
        }

        public bool ValidarNoticia(int id, bool status)
        {
            return new UsuarioAdmin().ValidarNoticia(id, status).Result;
        }
    }
}
