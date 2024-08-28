using AlgorithmVisualiser.SortAlgorithms.Interfaces;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmVisualiser.SortAlgorithms.Algorithms
{
	public class MergeSort : ISortStrategy
	{
		Visualizer _visualizer;

		public MergeSort(Visualizer visualizer)
		{
			_visualizer = visualizer;
		}

		public void Sort(IList array)
		{
			Sorter(array, 0, array.Count - 1);
		}

		public IList Sorter(IList array, int low, int height)
		{
			int l = low;
			int h = height;

			if (l >= h)
			{
				return array;
			}

			int mid = (l + h) / 2;
			Sorter(array, l, mid);
			Sorter(array, mid + 1, h);

			int end_lo = mid;
			int start_hi = mid + 1;
			while ((l <= end_lo) && (start_hi <= h))
			{
				if (((IComparable)array[l]).CompareTo(array[start_hi]) < 0)
				{
					l++;
				}
				else
				{
					object temp = array[start_hi];
					for (int k = start_hi - 1; k >= l; k--)
					{
						array[k + 1] = array[k];
						_visualizer.DrawNew(array, k + 1);
						_visualizer.RefreshPanel();
					}
					array[l] = temp;
					_visualizer.DrawNew(array, l);
					_visualizer.RefreshPanel();
					l++;
					end_lo++;
					start_hi++;
				}
			}
			return array;
		}
	}
}
