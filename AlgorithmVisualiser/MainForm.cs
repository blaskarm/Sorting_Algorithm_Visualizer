using System.Collections;
using System.Linq;
using AlgorithmVisualiser.SortAlgorithms;

namespace AlgorithmVisualiser
{
	public partial class MainForm : Form
	{
		Bitmap bm1;
		Graphics g1;
		Pen pen;
		ArrayList array;
		InsertionSort insertionSort;

		public MainForm()
		{
			InitializeComponent();
			counterLabel.Text = arraySizeTb.Value.ToString();

			bm1 = new Bitmap(pb1.Width, pb1.Height);
			g1 = Graphics.FromImage(bm1);
			pb1.Image = bm1;
			pen = new Pen(Color.Black);

			insertionSort = new InsertionSort(this, bm1, g1, pen);
		}

		private void shuffleBtn_Click(object sender, EventArgs e)
		{
			MakeArray();
			RandomizeArray();
			DrawArray();
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

		private void DrawArray()
		{
			pb1.Image = bm1;
			g1.Clear(Color.White);

			for (int i = 0; i < array.Count; i++)
			{
				int x = (int)(((double)pb1.Width / array.Count) * i);
				g1.DrawLine(pen, new Point(x, pb1.Height), new Point(x, (int)pb1.Height - (int)array[i]));
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

		private void clearBtn_Click(object sender, EventArgs e)
		{
			pb1.Image = bm1;
			g1.Clear(Color.White);
		}

		private void sortBtn_Click(object sender, EventArgs e)
		{
			insertionSort.Sort(array);
			//DrawArray();
		}

		private void arraySizeTb_ValueChanged(object sender, EventArgs e)
		{
			counterLabel.Text = arraySizeTb.Value.ToString();
		}
	}
}
