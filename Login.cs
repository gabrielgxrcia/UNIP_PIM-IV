using System;
using System.Drawing;
using System.IO;
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
                byte[] imagemFuncionario = null;

                if(validar.SearchFuncionario(email)) {

                    if(validar.ImagemFuncionario == null) {
                        menu_.bunifuPictureBox2.Image = Image.FromFile("C:\\Users\\kelvy\\OneDrive\\Documentos\\Faculdade\\PIM\\Windows_Forms_DeskTop_Bckp_Dark2_Package_Final\\Resources\\image-removebg-preview.png");
                    }
                    else
                    {
                        MemoryStream memory = new MemoryStream(validar.ImagemFuncionario);
                        menu_.bunifuPictureBox2.Image = Image.FromStream(memory);
                    }

                    menu_.bunifuLabel17.Text = validar.NomeCompleto;
                    menu_.bunifuLabel18.Text = validar.Email;
                    menu_.bunifuTextBox4.Text = validar.NomeCompleto;
                    menu_.bunifuTextBox5.Text = validar.Email;
                    menu_.bunifuTextBox6.Text = validar.Celular;
                    menu_.bunifuTextBox7.Text = validar.Cargo;
                }

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
