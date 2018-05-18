using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            if (BoxPassword.Text == "Admin" && BoxLogin.Text == "Admin")
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
