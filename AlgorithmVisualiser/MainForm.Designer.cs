namespace AlgorithmVisualiser
{
	partial class MainForm
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			pb1 = new PictureBox();
			shuffleBtn = new Button();
			clearBtn = new Button();
			arraySizeTb = new TrackBar();
			counterLabel = new Label();
			sortBtn = new Button();
			algorithmCb = new ComboBox();
			label1 = new Label();
			label2 = new Label();
			((System.ComponentModel.ISupportInitialize)pb1).BeginInit();
			((System.ComponentModel.ISupportInitialize)arraySizeTb).BeginInit();
			SuspendLayout();
			// 
			// pb1
			// 
			pb1.BackColor = Color.White;
			pb1.BorderStyle = BorderStyle.FixedSingle;
			pb1.Location = new Point(175, 77);
			pb1.Name = "pb1";
			pb1.Size = new Size(600, 200);
			pb1.TabIndex = 0;
			pb1.TabStop = false;
			// 
			// shuffleBtn
			// 
			shuffleBtn.Location = new Point(417, 349);
			shuffleBtn.Name = "shuffleBtn";
			shuffleBtn.Size = new Size(112, 34);
			shuffleBtn.TabIndex = 1;
			shuffleBtn.Text = "Shuffle";
			shuffleBtn.UseVisualStyleBackColor = true;
			shuffleBtn.Click += shuffleBtn_Click;
			// 
			// clearBtn
			// 
			clearBtn.Location = new Point(667, 353);
			clearBtn.Name = "clearBtn";
			clearBtn.Size = new Size(112, 34);
			clearBtn.TabIndex = 2;
			clearBtn.Text = "Clear";
			clearBtn.UseVisualStyleBackColor = true;
			clearBtn.Click += clearBtn_Click;
			// 
			// arraySizeTb
			// 
			arraySizeTb.Location = new Point(175, 349);
			arraySizeTb.Maximum = 1000;
			arraySizeTb.Minimum = 10;
			arraySizeTb.Name = "arraySizeTb";
			arraySizeTb.Size = new Size(156, 69);
			arraySizeTb.TabIndex = 3;
			arraySizeTb.Value = 10;
			arraySizeTb.ValueChanged += arraySizeTb_ValueChanged;
			// 
			// counterLabel
			// 
			counterLabel.AutoSize = true;
			counterLabel.Location = new Point(312, 321);
			counterLabel.Name = "counterLabel";
			counterLabel.Size = new Size(0, 25);
			counterLabel.TabIndex = 4;
			// 
			// sortBtn
			// 
			sortBtn.Location = new Point(417, 462);
			sortBtn.Name = "sortBtn";
			sortBtn.Size = new Size(112, 34);
			sortBtn.TabIndex = 5;
			sortBtn.Text = "Sort";
			sortBtn.UseVisualStyleBackColor = true;
			sortBtn.Click += sortBtn_Click;
			// 
			// algorithmCb
			// 
			algorithmCb.DropDownStyle = ComboBoxStyle.DropDownList;
			algorithmCb.Items.AddRange(new object[] { "Insertion Sort", "Bubble Sort", "Quick Sort", "Selection Sort" });
			algorithmCb.Location = new Point(597, 462);
			algorithmCb.Name = "algorithmCb";
			algorithmCb.Size = new Size(182, 33);
			algorithmCb.TabIndex = 6;
			algorithmCb.SelectedIndexChanged += algorithmCb_SelectedIndexChanged;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(597, 434);
			label1.Name = "label1";
			label1.Size = new Size(92, 25);
			label1.TabIndex = 7;
			label1.Text = "Algorithm";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(175, 321);
			label2.Name = "label2";
			label2.Size = new Size(90, 25);
			label2.TabIndex = 8;
			label2.Text = "Array Size";
			// 
			// MainForm
			// 
			AutoScaleDimensions = new SizeF(10F, 25F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(928, 545);
			Controls.Add(label2);
			Controls.Add(label1);
			Controls.Add(algorithmCb);
			Controls.Add(sortBtn);
			Controls.Add(counterLabel);
			Controls.Add(arraySizeTb);
			Controls.Add(clearBtn);
			Controls.Add(shuffleBtn);
			Controls.Add(pb1);
			Name = "MainForm";
			Text = "Form1";
			((System.ComponentModel.ISupportInitialize)pb1).EndInit();
			((System.ComponentModel.ISupportInitialize)arraySizeTb).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private PictureBox pb1;
		private Button shuffleBtn;
		private Button clearBtn;
		private TrackBar arraySizeTb;
		private Label counterLabel;
		private Button sortBtn;
		private ComboBox algorithmCb;
		private Label label1;
		private Label label2;
	}
}
