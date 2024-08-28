using AlgorithmVisualiser.SortAlgorithms.Interfaces;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmVisualiser.SortAlgorithms.Algorithms
{
	public class SelectionSort : ISortStrategy
	{
		Visualizer _visualizer;

		public SelectionSort(Visualizer visualizer)
		{
			_visualizer = visualizer;
		}

		public void Sort(IList array)
		{
			for (int i = 0; i < array.Count - 1; i++)
			{
				int smallest = i;
				for (int j = i + 1; j < array.Count; j++)
				{
					if (((IComparable)array[j]).CompareTo(array[smallest]) < 0)
					{
						smallest = j;
					}
				}
				var temp = array[smallest];
				array[smallest] = array[i];
				_visualizer.DrawNew(array, smallest);
				_visualizer.RefreshPanel();

				array[i] = temp;
				_visualizer.DrawNew(array, i);
				_visualizer.RefreshPanel();

				//Thread.Sleep(500);
			}
		}
	}
}
