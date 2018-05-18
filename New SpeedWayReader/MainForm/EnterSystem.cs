using System;
using System.Windows.Forms;

namespace MainForm
{
    public partial class EnterSystem : Form
    {
        public EnterSystem()
        {
            InitializeComponent();
        }

        private void BtnEnter_Click(object sender, EventArgs e)
        {
            if (BoxPassword.Text == "Admin" && BoxLogin.Text == "Admin" || BoxPassword.Text == "User" && BoxLogin.Text == "User")
            {
                this.Hide();
                Main formmain = new Main();
                formmain.ShowDialog();
            }
            else
            {
                MessageBox.Show("Не правильный пароль!");
            }
        }
    }
}
