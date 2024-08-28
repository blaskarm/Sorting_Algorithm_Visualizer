using System.Collections;
using System.Diagnostics;
using System.Linq;
using AlgorithmVisualiser.SortAlgorithms;
using AlgorithmVisualiser.SortAlgorithms.Algorithms;
using AlgorithmVisualiser.SortAlgorithms.Context;

namespace AlgorithmVisualiser
{
    public partial class MainForm : Form
	{
		Bitmap bm1;
		Graphics g1;
		Pen pen;
		ArrayList array;
		Visualizer visualizer;
		Sorter sorter;

		public MainForm()
		{
			InitializeComponent();
			counterLabel.Text = arraySizeTb.Value.ToString();

			bm1 = new Bitmap(pb1.Width, pb1.Height);
			g1 = Graphics.FromImage(bm1);
			pen = new Pen(Color.Black);

			visualizer = new Visualizer(this.pb1, g1);
			sorter = new Sorter(new InsertionSort(visualizer));
		}

		private void shuffleBtn_Click(object sender, EventArgs e)
		{
			MakeArray();
			RandomizeArray();
			pb1.Image = bm1;
			visualizer.DrawArray(array);
		}

		private void clearBtn_Click(object sender, EventArgs e)
		{
			pb1.Image = bm1;
			g1.Clear(Color.White);
		}

		private void sortBtn_Click(object sender, EventArgs e)
		{
			Stopwatch stopWatch = new Stopwatch();
			stopWatch.Start();
			sorter.Sort(array);
			stopWatch.Stop();
			timerLabel.Text = stopWatch.Elapsed.ToString();
		}

		private void arraySizeTb_ValueChanged(object sender, EventArgs e)
		{
			counterLabel.Text = arraySizeTb.Value.ToString();
		}

		private void RandomizeArray()
		{
			Random r = new Random();

			for (int i = array.Count - 1; i > 0; i--)
			{
				int j = r.Next(0, i + 1);

				object temp = array[i];
				array[i] = array[j];
				array[j] = temp;
			}
		}

		private void MakeArray()
		{
			array = new ArrayList(arraySizeTb.Value);
			for (int i = 0; i < array.Capacity; i++)
			{
				int y = (int)((double)i / array.Capacity * pb1.Height);
				array.Add(y);
			}
		}

		private void algorithmCb_SelectedIndexChanged(object sender, EventArgs e)
		{
			SetSortingAlgorithm(algorithmCb.SelectedItem as string);
		}

		private void SetSortingAlgorithm(string? v)
		{
			switch (v)
			{
				case "Insertion Sort":
					sorter.SetSortAlgorithm(new InsertionSort(visualizer));
					break;
				case "Bubble Sort":
					sorter.SetSortAlgorithm(new BubbleSort(visualizer));
					break;
				case "Quick Sort":
					sorter.SetSortAlgorithm(new QuickSort(visualizer));
					break;
				case "Selection Sort":
					sorter.SetSortAlgorithm(new SelectionSort(visualizer));
					break;
				case "Merge Sort":
					sorter.SetSortAlgorithm(new MergeSort(visualizer));
					break;
			}
		}
	}
}
