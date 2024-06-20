using sttopnews.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sttopnews.Model
{
    public class CollectionTabview
    {
        public string Categoria { get; set; }
        public List<Noticias> Noticias { get; set; }
    }
}
