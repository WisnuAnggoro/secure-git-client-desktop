using System;
using System.Windows.Forms;
using System.Drawing;

namespace SecureGitClient
{
	public partial class MainForm : Form
	{
		public Button button1;

        public void Render()
		{
			button1 = new Button();
			button1.Size = new Size(40, 40);
			button1.Location = new Point(30, 30);
			button1.Text = "Click me";
			this.Controls.Add(button1);
			button1.Click += new EventHandler(button1_Click);
        }

		[STAThread]
		static void Main()
		{
			Application.EnableVisualStyles();
			Application.Run(new MainForm());
		}
	}
}
