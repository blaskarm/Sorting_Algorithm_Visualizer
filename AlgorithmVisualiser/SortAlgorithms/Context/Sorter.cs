using AlgorithmVisualiser.SortAlgorithms.Interfaces;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmVisualiser.SortAlgorithms.Context
{
	public class Sorter
	{
		private ISortStrategy _sorter;

		public Sorter(ISortStrategy sorter)
		{
			_sorter = sorter;
		}

		public void SetSortAlgorithm(ISortStrategy sorter)
		{
			_sorter = sorter;
		}

		public void Sort(IList array)
		{
			_sorter.Sort(array);
		}
	}
}
