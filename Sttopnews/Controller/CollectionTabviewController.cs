using Sttopnews.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sttopnews.Controller
{
    public class CollectionTabviewController
    {
        public List<CollectionTabview> ListaNoticias()
        {
            int x = 0;
            var Lista = new List<CollectionTabview>();
            var Categorias = new CategoriasController().listarCategorias();
            var ListaCategorias = new List<string>();
            foreach(var item in Categorias)
            {
                ListaCategorias.Add(item.Categoria);
            }
            foreach (var item in new NoticiasController().CarregarNoticiasCategoria())
            {
                Lista.Add(new CollectionTabview 
                {
                    Categoria = ListaCategorias[x],
                    Noticias = item
                });
                x++;
            }
            return Lista;
        }
    }
}
