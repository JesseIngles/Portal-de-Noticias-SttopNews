using sttopnews.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sttopnews.Controller
{
    public class UsuarioController
    {
        public string CriarConta(Usuario user)
        {
            return new Usuario().CriarConta(user).Result;
        }
        public Usuario FazerLogin(Usuario user)
        {
            return new Usuario().FazerLogin(user).Result;
        }
        public bool FazerLogOut(string telefone, bool status)
        {
            return new Usuario().FazerLogOut(telefone, status).Result;
        }
    }
}
