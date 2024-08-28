using AlgorithmVisualiser.SortAlgorithms.Interfaces;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmVisualiser.SortAlgorithms
{
	public class BubbleSort : ISortStrategy
	{
		Visualizer visualizer;
		public BubbleSort(Visualizer visualizer)
		{
			this.visualizer = visualizer;
		}

		public void Sort(IList array)
		{
			bool swapped;
			for (int i = 0; i < array.Count - 1; i++)
			{
				swapped = false;
				for (int j = 0; j < array.Count - i - 1; j++)
				{
					if (((IComparable)array[j]).CompareTo(array[j + 1]) > 0)
					{
						object temp = array[j];
						array[j] = array[j + 1];
						visualizer.DrawNew(array, j);
						visualizer.RefreshPanel();
						array[j + 1] = temp;
						visualizer.DrawNew(array, j + 1);
						visualizer.RefreshPanel();
						Thread.Sleep(300);
						swapped = true;
					}
				}
				if (!swapped)
					return;
				Thread.Sleep(1000);
			}
		}
	}
}
