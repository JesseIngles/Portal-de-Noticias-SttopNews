using sttopnews.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sttopnews.Controller
{
    public class UsuarioRedactorController
    {
        public bool CadastrarNoticia(Noticias noticia)
        {
            return new UsuarioRedactor().CadastrarNoticia(noticia).Result;
        }

        public Noticias CarregarNoticia(int id)
        {
            return new UsuarioRedactor().CarregarNoticia(id).Result;
        }

        public List<Noticias> CarregarNoticias()
        {
            return new UsuarioRedactor().CarregarNoticias().Result;
        }

        public string EditarNoticia(Noticias noticia)
        {
            return new UsuarioRedactor().EditarNoticia(noticia).Result;
        }
    }
}
