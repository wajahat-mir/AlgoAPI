using Algo.Bll.Models.Sort;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algo.Bll.Interfaces
{
    public interface ISortService
    {
        List<SortStep> InsertionSort(List<int> numbers);
    }
}
