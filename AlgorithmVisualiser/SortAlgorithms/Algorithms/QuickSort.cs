using AlgorithmVisualiser.SortAlgorithms.Interfaces;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmVisualiser.SortAlgorithms.Algorithms
{
    public class QuickSort : ISortStrategy
    {
        Visualizer _visualizer;
        public QuickSort(Visualizer visualizer)
        {
            _visualizer = visualizer;
        }

        public void Sort(IList array)
        {
            Sorter(array, 0, array.Count - 1);
        }

        private void Sorter(IList array, int low, int high)
        {
            if (low >= high)
                return;

            int pivot = Partition(array, low, high);
            Sorter(array, low, pivot - 1);
            Sorter(array, pivot + 1, high);
        }

        private int Partition(IList array, int low, int high)
        {
            object pivot = array[high];
            int i = low - 1;

            for (int j = low; j < high; j++)
            {
                if (((IComparable)array[j]).CompareTo(pivot) < 0)
                {
                    i++;
                    Swap(array, i, j);
                }
            }
            Swap(array, i + 1, high);
            //Thread.Sleep(1000);
            return i + 1;
        }

        private void Swap(IList array, int i, int j)
        {
            var temp = array[i];
            array[i] = array[j];
            _visualizer.DrawNew(array, i);
            _visualizer.RefreshPanel();

            array[j] = temp;
            _visualizer.DrawNew(array, j);
            _visualizer.RefreshPanel();
            //Thread.Sleep(300);
        }
    }
}
