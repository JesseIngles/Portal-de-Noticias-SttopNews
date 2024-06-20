using sttopnews.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Sttopnews.Controller
{
    public class UsuarioLeitorController
    {
        public List<NoticiaComentarios> CarregarComentarios(int id)
        {
            return new UsuarioLeitor().CarregarComentarios(id).Result;
        }

        public bool ComentarNoticia(int id)
        {
            return new UsuarioLeitor().ComentarNoticia(id).Result;
        }

        public bool EditarComentário(int id)
        {
            return new UsuarioLeitor().EditarComentário(id).Result;
        }

        public bool ExcluirComentario(int id)
        {
            return new UsuarioLeitor().ExcluirComentario(id).Result;
        }
    }
}
