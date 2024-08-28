using AlgorithmVisualiser.SortAlgorithms.Interfaces;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmVisualiser.SortAlgorithms.Algorithms
{
    public class InsertionSort : ISortStrategy
    {
        Visualizer _visualizer;

        public InsertionSort(Visualizer visualizer)
        {
            _visualizer = visualizer;
        }

        public void Sort(IList array)
        {
            for (int i = 1; i < array.Count; i++)
            {
                for (int j = i; j > 0 && ((IComparable)array[j]).CompareTo(array[j - 1]) < 0; j--)
                {
                    var temp = array[j];
                    array[j] = array[j - 1];
                    _visualizer.DrawNew(array, j);
                    _visualizer.RefreshPanel();
                    array[j - 1] = temp;
                    _visualizer.DrawNew(array, j - 1);
                    _visualizer.RefreshPanel();
                    //Thread.Sleep(300);
                }
                //Thread.Sleep(1000);
            }
        }
    }
}
