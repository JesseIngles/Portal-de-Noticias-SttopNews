using sttopnews.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sttopnews.Controller
{
    public class NoticiasController
    {
        public Noticias CarregarNoticia(int id)
        {
            return new Noticias().CarregarNoticia(id).Result;
        }
        public List<Noticias> CarregarNoticias()
        {
            return new Noticias().CarregarNoticias().Result;
        }
        public List<List<Noticias>> CarregarNoticiasCategoria()
        {
            var ListaGlobal = new List<List<Noticias>>();
            var Lista = CarregarNoticias();
            var Categorias = new Categorias().listarCategorias().Result;
            var ListaHelp = new List<Noticias>();
            foreach(var item in Categorias)
            {
                foreach(var c in Lista)
                {
                    if(c.Categoria == item.Categoria)
                    {
                        ListaHelp.Add(c);
                    }
                }
                ListaGlobal.Add(ListaHelp);
                ListaHelp.Clear();
            }
            return ListaGlobal;
        }
    }
}
