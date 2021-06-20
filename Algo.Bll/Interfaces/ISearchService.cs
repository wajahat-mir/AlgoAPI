using Algo.Bll.Models.Search;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algo.Bll.Interfaces
{
    public interface ISearchService
    {
        List<Vertex> BreadFirstSearch(int source, Dictionary<int, List<int>> adjacencyList);
        List<Vertex> DepthFirstSearch(Dictionary<int, List<int>> adjacencyList);
    }
}
