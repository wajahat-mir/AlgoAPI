using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algo.Bll.Models.Sort
{
    public class ItemModel
    {
        public int index { get; set; }
        public int value { get; set; }

        public ItemModel(int index, int value)
        {
            this.index = index;
            this.value = value;
        }
    }
}
