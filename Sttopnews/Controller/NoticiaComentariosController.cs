using sttopnews.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sttopnews.Controller
{
    public class NoticiaComentariosController
    {
        public List<NoticiaComentarios> CarregarComentarios(int id)
        {
            return new NoticiaComentarios().CarregarComentarios(id).Result;
        }

        public bool ExcluirComentario(int id)
        {
            return new NoticiaComentarios().ExcluirComentario(id).Result;
        }
    }
}
