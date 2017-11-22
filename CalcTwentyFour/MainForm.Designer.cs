namespace CalcTwentyFour
{
	partial class MainForm
	{
		/// <summary>
		/// 必需的设计器变量。
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// 清理所有正在使用的资源。
		/// </summary>
		/// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows 窗体设计器生成的代码

		/// <summary>
		/// 设计器支持所需的方法 - 不要
		/// 使用代码编辑器修改此方法的内容。
		/// </summary>
		private void InitializeComponent()
		{
            this.panel1 = new System.Windows.Forms.Panel();
            this.Num1_TextBox = new System.Windows.Forms.TextBox();
            this.Num2_TextBox = new System.Windows.Forms.TextBox();
            this.StartButton = new System.Windows.Forms.Button();
            this.Num3_TextBox = new System.Windows.Forms.TextBox();
            this.Num4_TextBox = new System.Windows.Forms.TextBox();
            this.ResultListBox = new System.Windows.Forms.ListBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Num1_TextBox);
            this.panel1.Controls.Add(this.Num2_TextBox);
            this.panel1.Controls.Add(this.StartButton);
            this.panel1.Controls.Add(this.Num3_TextBox);
            this.panel1.Controls.Add(this.Num4_TextBox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(246, 31);
            this.panel1.TabIndex = 8;
            // 
            // Num1_TextBox
            // 
            this.Num1_TextBox.Font = new System.Drawing.Font("宋体", 11F);
            this.Num1_TextBox.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.Num1_TextBox.Location = new System.Drawing.Point(3, 3);
            this.Num1_TextBox.MaxLength = 2;
            this.Num1_TextBox.Name = "Num1_TextBox";
            this.Num1_TextBox.Size = new System.Drawing.Size(25, 24);
            this.Num1_TextBox.TabIndex = 0;
            this.Num1_TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Num1_TextBox.TextChanged += new System.EventHandler(this.Num_TextBox_TextChanged);
            // 
            // Num2_TextBox
            // 
            this.Num2_TextBox.Font = new System.Drawing.Font("宋体", 11F);
            this.Num2_TextBox.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.Num2_TextBox.Location = new System.Drawing.Point(45, 3);
            this.Num2_TextBox.MaxLength = 2;
            this.Num2_TextBox.Name = "Num2_TextBox";
            this.Num2_TextBox.Size = new System.Drawing.Size(25, 24);
            this.Num2_TextBox.TabIndex = 1;
            this.Num2_TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Num2_TextBox.TextChanged += new System.EventHandler(this.Num_TextBox_TextChanged);
            // 
            // StartButton
            // 
            this.StartButton.AutoSize = true;
            this.StartButton.Enabled = false;
            this.StartButton.Location = new System.Drawing.Point(174, 3);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(63, 23);
            this.StartButton.TabIndex = 4;
            this.StartButton.Text = "开始计算";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // Num3_TextBox
            // 
            this.Num3_TextBox.Font = new System.Drawing.Font("宋体", 11F);
            this.Num3_TextBox.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.Num3_TextBox.Location = new System.Drawing.Point(87, 3);
            this.Num3_TextBox.MaxLength = 2;
            this.Num3_TextBox.Name = "Num3_TextBox";
            this.Num3_TextBox.Size = new System.Drawing.Size(25, 24);
            this.Num3_TextBox.TabIndex = 2;
            this.Num3_TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Num3_TextBox.TextChanged += new System.EventHandler(this.Num_TextBox_TextChanged);
            // 
            // Num4_TextBox
            // 
            this.Num4_TextBox.Font = new System.Drawing.Font("宋体", 11F);
            this.Num4_TextBox.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.Num4_TextBox.Location = new System.Drawing.Point(129, 3);
            this.Num4_TextBox.MaxLength = 2;
            this.Num4_TextBox.Name = "Num4_TextBox";
            this.Num4_TextBox.Size = new System.Drawing.Size(25, 24);
            this.Num4_TextBox.TabIndex = 3;
            this.Num4_TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Num4_TextBox.TextChanged += new System.EventHandler(this.Num_TextBox_TextChanged);
            // 
            // ResultListBox
            // 
            this.ResultListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ResultListBox.Font = new System.Drawing.Font("宋体", 11F);
            this.ResultListBox.FormattingEnabled = true;
            this.ResultListBox.ItemHeight = 15;
            this.ResultListBox.Location = new System.Drawing.Point(0, 31);
            this.ResultListBox.Margin = new System.Windows.Forms.Padding(0);
            this.ResultListBox.Name = "ResultListBox";
            this.ResultListBox.Size = new System.Drawing.Size(246, 188);
            this.ResultListBox.TabIndex = 9;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(246, 219);
            this.Controls.Add(this.ResultListBox);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "计算24点小程序";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.TextBox Num1_TextBox;
		private System.Windows.Forms.TextBox Num2_TextBox;
		private System.Windows.Forms.Button StartButton;
		private System.Windows.Forms.TextBox Num3_TextBox;
		private System.Windows.Forms.TextBox Num4_TextBox;
		private System.Windows.Forms.ListBox ResultListBox;
	}
}

