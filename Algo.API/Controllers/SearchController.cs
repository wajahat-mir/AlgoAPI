using Algo.Bll.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Algo.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SearchController : ControllerBase
    {

        private readonly ISearchService _searchService;

        public SearchController(ISearchService searchService)
        {
            _searchService = searchService;
        }

        [HttpPost]
        [Route("breadthfirst/{source}")]
        public IActionResult BreadthFirstSearch([FromRoute] int source, [FromBody] Dictionary<int, List<int>> adjacencyList)
        {
            if (!adjacencyList.ContainsKey(source))
                return BadRequest("Source does not exist in adjacency list");

            var updatedVertices = _searchService.BreadFirstSearch(source, adjacencyList);

            return Ok(updatedVertices);
        }

        [HttpPost]
        [Route("depthfirst")]
        public IActionResult DepthFirstSearch([FromBody] Dictionary<int, List<int>> adjacencyList)
        {
            var updatedVertices = _searchService.DepthFirstSearch(adjacencyList);

            return Ok(updatedVertices);
        }
    }
}
