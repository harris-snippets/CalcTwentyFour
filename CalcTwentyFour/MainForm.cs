using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CalcLibrary;

namespace CalcTwentyFour
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
		}

		int num1, num2, num3, num4;

		private void StartButton_Click(object sender, EventArgs e)
		{
			ResultListBox.Items.Clear();

			TwentyFourManager manager = new TwentyFourManager();

			IEnumerable<string> answer = manager.Calculate(num1, num2, num3, num4);

			if (answer.Count() == 0)
			{
				ResultListBox.Items.Add("没有找到计算24点的方法");
				return;
			}

			if (answer.Count() > 20)
				this.Height = 371;

			foreach (var item in answer)
			{
				ResultListBox.Items.Add(item);
			}
		}

		private void Num_TextBox_TextChanged(object sender, EventArgs e)
		{
			try
			{
				num1 = int.Parse(Num1_TextBox.Text);
				num2 = int.Parse(Num2_TextBox.Text);
				num3 = int.Parse(Num3_TextBox.Text);
				num4 = int.Parse(Num4_TextBox.Text);

				StartButton.Enabled = true;
			}
			catch (Exception)
			{
				StartButton.Enabled = false;
			}
		}

		private void Num_TextBox_KeyPress(object sender, KeyPressEventArgs e)
		{
			if ((e.KeyChar < (char)Keys.D0 || e.KeyChar > (char)Keys.D9) && e.KeyChar != (char)Keys.Back)
			{
				System.Media.SystemSounds.Beep.Play();
				e.Handled = true;
			}
		}

		
	}
}
