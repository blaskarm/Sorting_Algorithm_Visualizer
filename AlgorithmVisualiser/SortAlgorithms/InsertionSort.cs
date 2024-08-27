using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmVisualiser.SortAlgorithms
{
	public class InsertionSort
	{
		Bitmap bm1;
		Graphics g1;
		Pen pen;
		MainForm mainForm;

		public InsertionSort(MainForm mainForm, Bitmap bm1, Graphics g1, Pen pen)
		{
			this.mainForm = mainForm;
			this.bm1 = bm1;
			this.g1 = g1;
			this.pen = pen;
		}

		public void Sort(IList array)
		{
			for (int i = 1; i < array.Count; i++)
			{
				for (int j = i; j > 0 && ((IComparable)array[j]).CompareTo(array[j - 1]) < 0; j--)
				{
					object temp = array[j];
					array[j] = array[j - 1];
					DrawNew(array, j);
					RefreshPanel(mainForm.pb1);
					array[j - 1] = temp;
					DrawNew(array, j - 1);
					RefreshPanel(mainForm.pb1);
					Thread.Sleep(300);
				}
				Thread.Sleep(1000);
			}
		}

		private void DrawNew(IList array, int index)
		{
			mainForm.pb1.Image = bm1;
			int x = (int)(((double)mainForm.pb1.Width / array.Count) * index);
			g1.DrawLine(new Pen(Color.White), new Point(x, 0), new Point(x, mainForm.pb1.Height));
			g1.DrawLine(pen, new Point(x, mainForm.pb1.Height), new Point(x, (int)(mainForm.pb1.Height - (int)array[index])));

		}

		delegate void SetControlValueCallback(Control pnlSort);

		private void RefreshPanel(Control panel)
		{
			if (panel.InvokeRequired)
			{
				SetControlValueCallback d = new SetControlValueCallback(RefreshPanel);
				panel.Invoke(d, new object[] { panel });
			}
			else
			{
				panel.Refresh();
			}
		}
	}
}
