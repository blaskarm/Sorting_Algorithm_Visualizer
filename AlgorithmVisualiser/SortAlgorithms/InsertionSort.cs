using AlgorithmVisualiser.SortAlgorithms.Interfaces;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmVisualiser.SortAlgorithms
{
	public class InsertionSort : ISortStrategy
	{
		Visualizer visualizer;

		public InsertionSort(Visualizer visualizer)
		{
			this.visualizer = visualizer;
		}

		public void Sort(IList array)
		{
			for (int i = 1; i < array.Count; i++)
			{
				for (int j = i; j > 0 && ((IComparable)array[j]).CompareTo(array[j - 1]) < 0; j--)
				{
					object temp = array[j];
					array[j] = array[j - 1];
					visualizer.DrawNew(array, j);
					visualizer.RefreshPanel();
					array[j - 1] = temp;
					visualizer.DrawNew(array, j - 1);
					visualizer.RefreshPanel();
					Thread.Sleep(300);
				}
				Thread.Sleep(1000);
			}
		}
	}
}
