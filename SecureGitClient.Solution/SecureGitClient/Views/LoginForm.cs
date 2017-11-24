using System;
using System.Drawing;
using System.Security;
using System.Windows.Forms;

namespace SecureGitClient.Views
{
    public class LoginForm : Form
    {
		public Label lblUsername;
		public Label lblPassword;
		public TextBox txtUsername;
		public TextBox txtPassword;
        public Button btnOk;
        public Button btnCancel;

		public bool IsValid
        {
            get;
            private set;
        }

        public void RenderForm()
        {
            lblUsername = new Label();
			lblUsername.Size = new Size(40, 40); 
            lblUsername.Location = new Point(30, 30);
			lblUsername.Text = "Username";
			this.Controls.Add(lblUsername);

			lblPassword = new Label();
			lblPassword.Size = new Size(40, 40);
			lblPassword.Location = new Point(30, 30);
			lblPassword.Text = "Password";
			this.Controls.Add(lblUsername);

			btnOk = new Button();
			btnOk.Size = new Size(40, 40);
			btnOk.Location = new Point(30, 30);
			btnOk.Text = "Click me";
			this.Controls.Add(btnOk);
			btnOk.Click += new EventHandler(btnOk_Click);
        }

        public LoginForm(
            string username,
            SecureString password)
        {
            RenderForm();
        }

		private void btnOk_Click(
			object sender,
			EventArgs e)
		{
			MessageBox.Show("Hello World");
		}
    }
}
