namespace LEARNING_ENTITY_FRAMEWORK
{
	partial class MainForm
	{
		private System.ComponentModel.IContainer components = null;

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
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.countriesListBox = new System.Windows.Forms.ListBox();
			this.pnlButtons = new System.Windows.Forms.Panel();
			this.pageCountLabel = new System.Windows.Forms.Label();
			this.separatorLabel = new System.Windows.Forms.Label();
			this.pageIndexLabel = new System.Windows.Forms.Label();
			this.lastButton = new System.Windows.Forms.Button();
			this.firstButton = new System.Windows.Forms.Button();
			this.nextButton = new System.Windows.Forms.Button();
			this.previousButton = new System.Windows.Forms.Button();
			this.pnlButtons.SuspendLayout();
			this.SuspendLayout();
			// 
			// countriesListBox
			// 
			this.countriesListBox.Dock = System.Windows.Forms.DockStyle.Fill;
			this.countriesListBox.FormattingEnabled = true;
			this.countriesListBox.Location = new System.Drawing.Point(0, 0);
			this.countriesListBox.Name = "countriesListBox";
			this.countriesListBox.Size = new System.Drawing.Size(426, 223);
			this.countriesListBox.TabIndex = 0;
			// 
			// pnlButtons
			// 
			this.pnlButtons.Controls.Add(this.pageCountLabel);
			this.pnlButtons.Controls.Add(this.separatorLabel);
			this.pnlButtons.Controls.Add(this.pageIndexLabel);
			this.pnlButtons.Controls.Add(this.lastButton);
			this.pnlButtons.Controls.Add(this.firstButton);
			this.pnlButtons.Controls.Add(this.nextButton);
			this.pnlButtons.Controls.Add(this.previousButton);
			this.pnlButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.pnlButtons.Location = new System.Drawing.Point(0, 223);
			this.pnlButtons.Name = "pnlButtons";
			this.pnlButtons.Size = new System.Drawing.Size(426, 41);
			this.pnlButtons.TabIndex = 1;
			// 
			// pageCountLabel
			// 
			this.pageCountLabel.AutoSize = true;
			this.pageCountLabel.Location = new System.Drawing.Point(371, 11);
			this.pageCountLabel.Name = "pageCountLabel";
			this.pageCountLabel.Size = new System.Drawing.Size(22, 13);
			this.pageCountLabel.TabIndex = 6;
			this.pageCountLabel.Text = "-----";
			// 
			// separatorLabel
			// 
			this.separatorLabel.AutoSize = true;
			this.separatorLabel.Location = new System.Drawing.Point(355, 11);
			this.separatorLabel.Name = "separatorLabel";
			this.separatorLabel.Size = new System.Drawing.Size(10, 13);
			this.separatorLabel.TabIndex = 5;
			this.separatorLabel.Text = ":";
			// 
			// pageIndexLabel
			// 
			this.pageIndexLabel.AutoSize = true;
			this.pageIndexLabel.Location = new System.Drawing.Point(327, 11);
			this.pageIndexLabel.Name = "pageIndexLabel";
			this.pageIndexLabel.Size = new System.Drawing.Size(22, 13);
			this.pageIndexLabel.TabIndex = 4;
			this.pageIndexLabel.Text = "-----";
			// 
			// lastButton
			// 
			this.lastButton.Location = new System.Drawing.Point(246, 6);
			this.lastButton.Name = "lastButton";
			this.lastButton.Size = new System.Drawing.Size(75, 23);
			this.lastButton.TabIndex = 3;
			this.lastButton.Text = "&Last";
			this.lastButton.UseVisualStyleBackColor = true;
			this.lastButton.Click += new System.EventHandler(this.LastButton_Click);
			// 
			// firstButton
			// 
			this.firstButton.Location = new System.Drawing.Point(3, 6);
			this.firstButton.Name = "firstButton";
			this.firstButton.Size = new System.Drawing.Size(75, 23);
			this.firstButton.TabIndex = 2;
			this.firstButton.Text = "&First";
			this.firstButton.UseVisualStyleBackColor = true;
			this.firstButton.Click += new System.EventHandler(this.FirstButton_Click);
			// 
			// nextButton
			// 
			this.nextButton.Location = new System.Drawing.Point(165, 6);
			this.nextButton.Name = "nextButton";
			this.nextButton.Size = new System.Drawing.Size(75, 23);
			this.nextButton.TabIndex = 1;
			this.nextButton.Text = "&Next";
			this.nextButton.UseVisualStyleBackColor = true;
			this.nextButton.Click += new System.EventHandler(this.NextButton_Click);
			// 
			// previousButton
			// 
			this.previousButton.Location = new System.Drawing.Point(84, 6);
			this.previousButton.Name = "previousButton";
			this.previousButton.Size = new System.Drawing.Size(75, 23);
			this.previousButton.TabIndex = 0;
			this.previousButton.Text = "&Previous";
			this.previousButton.UseVisualStyleBackColor = true;
			this.previousButton.Click += new System.EventHandler(this.PreviousButton_Click);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(426, 264);
			this.Controls.Add(this.countriesListBox);
			this.Controls.Add(this.pnlButtons);
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Main";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
			this.Load += new System.EventHandler(this.MainForm_Load);
			this.pnlButtons.ResumeLayout(false);
			this.pnlButtons.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.ListBox countriesListBox;
		private System.Windows.Forms.Panel pnlButtons;
		private System.Windows.Forms.Button nextButton;
		private System.Windows.Forms.Button previousButton;
		private System.Windows.Forms.Button lastButton;
		private System.Windows.Forms.Button firstButton;
		private System.Windows.Forms.Label pageCountLabel;
		private System.Windows.Forms.Label separatorLabel;
		private System.Windows.Forms.Label pageIndexLabel;
	}
}
