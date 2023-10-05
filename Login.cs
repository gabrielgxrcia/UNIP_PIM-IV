using System;
using System.Drawing;
using System.Windows.Forms;

namespace Windows_Forms_DeskTop
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();

        }

        private void rjButton1_Click(object sender, EventArgs e)
        {
            var menu_ = new menu_principal();
            var validar = new Validate();

            var email = guna2TextBox1.Text;
            var password = guna2TextBox2.Text;

            if (validar.Validate_Login(email,password) == true)
            {
                MessageBox.Show("Login efetuado com sucesso");
                menu_.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Email ou senha incorretos!");
                guna2TextBox1.Text = "";
                guna2TextBox2.Text = "";
            }
        }
    }
}
