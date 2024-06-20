using sttopnews.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sttopnews.Controller
{
    public class CategoriasController
    {
        public bool CadastrarCategoria(string categoria)
        {
            return new Categorias().CadastrarCategoria(categoria).Result;
        }

        public bool DeletarCategoria(int id)
        {
            return new Categorias().DeletarCategoria(id).Result;
        }

        public bool EditarCategoria(string categoria, int id)
        {
            return new Categorias().EditarCategoria(categoria, id).Result;
        }

        public Categorias ListarCategoria(int id)
        {
            return new Categorias().ListarCategoria(id).Result;
        }

        public List<Categorias> listarCategorias()
        {
            return new Categorias().listarCategorias().Result;
        }
    }
}
