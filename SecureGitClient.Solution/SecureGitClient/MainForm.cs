using System;
using System.Windows.Forms;

namespace SecureGitClient
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			Render();
		}

		private void button1_Click(
			object sender,
			EventArgs e)
		{
			MessageBox.Show("Hello World");
		}
	}
}