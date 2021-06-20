using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algo.Bll.Models.Search
{
    public class Vertex
    {
        public int id { get; set; }
        public string color { get; set; }

        public Vertex(int id, string color)
        {
            this.id = id;
            this.color = color;
        }
    }
}
