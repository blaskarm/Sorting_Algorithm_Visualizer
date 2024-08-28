using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace AlgorithmVisualiser
{
	public class Visualizer
	{
		Control pictureBox;
		Graphics graphics;

		public Visualizer(Control pictureBox, Graphics graphics)
		{
			this.pictureBox = pictureBox;
			this.graphics = graphics;
		}

		public void DrawArray(IList array)
		{
			graphics.Clear(Color.White);

			for (int i = 0; i < array.Count; i++)
			{
				int x = (int)(((double)pictureBox.Width / array.Count) * i);
				graphics.DrawLine(new Pen(Color.Black), new Point(x, pictureBox.Height), new Point(x, (int)pictureBox.Height - (int)array[i]));
			}
		}

		public void DrawNew(IList array, int index)
		{
			int x = (int)(((double)pictureBox.Width / array.Count) * index);
			graphics.DrawLine(new Pen(Color.White), new Point(x, 0), new Point(x, pictureBox.Height));
			graphics.DrawLine(new Pen(Color.Black), new Point(x, pictureBox.Height), new Point(x, (int)(pictureBox.Height - (int)array[index])));

		}

		delegate void SetControlValueCallback();

		public void RefreshPanel()
		{
			if (pictureBox.InvokeRequired)
			{
				SetControlValueCallback d = new SetControlValueCallback(RefreshPanel);
				pictureBox.Invoke(d, new object[] { pictureBox });
			}
			else
			{
				pictureBox.Refresh();
			}
		}
	}
}
