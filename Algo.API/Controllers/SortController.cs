using Algo.Bll.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Algo.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class SortController : ControllerBase
    {

        private readonly ILogger<SortController> _logger;
        private readonly ISortService _sortService;

        public SortController(ILogger<SortController> logger, ISortService sortService)
        {
            _logger = logger;
            _sortService = sortService;
        }

        [HttpPost]
        [Route("insertion")]
        public IActionResult InsertionSort(List<int> numbers)
        {
            var steps = _sortService.InsertionSort(numbers);

            if (steps == null || steps.Count() == 0)
                return NoContent();
            return Ok(steps);
        }
    }
}
