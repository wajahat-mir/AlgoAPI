using Algo.Bll.Interfaces;
using Algo.Bll.Models.Sort;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algo.Bll.Services
{
    public class SortService: ISortService
    {
        public List<SortStep> InsertionSort(List<int> numbers)
        {
            List<SortStep> sortSteps = new List<SortStep>();

            if(numbers.Count() > 0)
            {
                for (int j = 1; j < numbers.Count(); j++)
                {
                    int key = numbers[j];
                    int i = j - 1;
                    while(i >= 0 && numbers[i] > key)
                    {
                        var loopStep = new SortStep()
                        {
                            key = new ItemModel(j, key),
                            update = new ItemModel(i + 1, numbers[i])
                        };
                        sortSteps.Add(loopStep);

                        numbers[i + 1] = numbers[i];
                        i = i - 1;
                    }

                    var step = new SortStep()
                    {
                        key = new ItemModel(j, key),
                        update = new ItemModel(i + 1, key)
                    };
                    sortSteps.Add(step);

                    numbers[i + 1] = key;
                }
            }
            
            return sortSteps;
        }
    }
}
