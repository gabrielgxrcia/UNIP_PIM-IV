using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bunifu.UI.WinForms;
using System.IO;
using System.Drawing.Imaging;

namespace Windows_Forms_DeskTop
{
    public partial class menu_principal : Form
    {
        private NotifyIcon notifyIcon;
        private Validate data;

        public menu_principal()
        {
            InitializeComponent();
            data = new Validate();

            if (bunifuDataGridView1.Columns.Contains("Status"))
            {
                int rowIndex = 0;

                if (rowIndex >= 0 && rowIndex < bunifuDataGridView1.RowCount)
                {
                    DataGridViewImageCell imageCell = new DataGridViewImageCell();
                    Image image = Image.FromFile("C:\\Users\\kelvy\\OneDrive\\Documentos\\Faculdade\\PIM\\Windows_Forms_DeskTop_Bckp_Dark2_Package_Final\\ok.png");
                    imageCell.Value = image;

                    bunifuDataGridView1.Rows[rowIndex].Cells["Status"] = imageCell;
                }
            }
        }

        private void bunifuButton5_Click(object sender, EventArgs e)
        {
            bunifuPages1.SetPage("Dashboard");
        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            bunifuPages1.SetPage("Funcionario");
        }

        private void bunifuButton2_Click(object sender, EventArgs e)
        {
            bunifuPages1.SetPage("Tarefas");
        }

        private void bunifuButton8_Click(object sender, EventArgs e)
        {
            bunifuPages1.SetPage("Configurações");
        }

        private void bunifuButton12_Click(object sender, EventArgs e)
        {
            bunifuPages1.SetPage("Impostos");
        }

        private void bunifuButton11_Click(object sender, EventArgs e)
        {
            bunifuPages1.SetPage("Notificações");
        }

        private void bunifuButton3_Click(object sender, EventArgs e)
        {
            bunifuPages1.SetPage("Folha");
        }

        private void bunifuButton34_Click(object sender, EventArgs e)
        {
            bunifuPages1.SetPage("Times");
        }

        private void bunifuTextBox8_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) 
            {
                var name = bunifuTextBox8.Text;
                var data = new Validate();

                if (data != null)
                {
                    data.SearchFuncionario(name);
                    bunifuTextBox24.Text = data.NomeCompleto;
                    bunifuTextBox23.Text = data.CPF;
                    bunifuTextBox32.Text = data.Cargo;
                    bunifuTextBox29.Text = data.Email;
                    bunifuTextBox25.Text = data.Reservista;
                    bunifuTextBox26.Text = data.TituloEleitor;
                    bunifuTextBox28.Text = data.Celular;
                    bunifuDropdown4.Text = data.EstadoCivil;
                    bunifuTextBox31.Text = data.Funcao;
                    bunifuTextBox35.Text = data.Banco;
                    bunifuTextBox34.Text = data.Agencia;
                    bunifuTextBox33.Text = data.CC;
                    bunifuTextBox39.Text = data.Endereco;
                    bunifuTextBox38.Text = data.Bairro;
                    bunifuTextBox37.Text = data.Numero;
                    bunifuTextBox36.Text = data.CEP;
                    bunifuTextBox41.Text = data.Complemento;
                    bunifuTextBox40.Text = data.Estado;
                    bunifuTextBox42.Text = data.Escolaridade;
                    bunifuDropdown5.Text = data.Filhos;
                    bunifuDropdown6.Text = data.PCD;
                    bunifuTextBox30.Text = data.SalarioBase;
                    bunifuTextBox27.Text = data.RG;
                    bunifuDatePicker4.Text = data.DataNasc;
                    bunifuDatePicker5.Text = data.DataAdmissao;
                    bunifuDropdown3.Text = data.Sexo;

                    if (data.ImagemFuncionario == null)
                    {
                        bunifuPictureBox5.Image = Image.FromFile("C:\\Users\\kelvy\\OneDrive\\Documentos\\Faculdade\\PIM\\Windows_Forms_DeskTop_Bckp_Dark2_Package_Final\\Resources\\image-removebg-preview.png");
                    }
                    else
                    {
                        MemoryStream memory = new MemoryStream(data.ImagemFuncionario);
                        bunifuPictureBox5.Image = Image.FromStream(memory);
                    }
                        

                    DisableControls();
                }
                else 
                {
                    MessageBox.Show("erro");
                }
                bunifuTextBox8.Text = "";
            }
        }

        private void bunifuButton31_Click(object sender, EventArgs e)
        {
            EnableControls();
        }

        private void bunifuButton32_Click(object sender, EventArgs e)
        {
            string nomeCompleto = bunifuTextBox24.Text;
            var cpf = bunifuTextBox23.Text;
            var rg = bunifuTextBox27.Text;
            string email = bunifuTextBox29.Text;
            string dataNasc = bunifuDatePicker4.Text;
            string reservista = bunifuTextBox25.Text;
            string tituloEleitor = bunifuTextBox26.Text;
            string celular = bunifuTextBox28.Text;
            string sexo = bunifuDropdown3.Text;
            string estadoCivil = bunifuDropdown4.Text;
            string dataAdmissao = bunifuDatePicker5.Text;
            string cargo = bunifuTextBox32.Text;
            string funcao = bunifuTextBox31.Text;
            string salarioBase = bunifuTextBox30.Text;
            string banco = bunifuTextBox35.Text;
            string agencia = bunifuTextBox34.Text;
            string cc = bunifuTextBox33.Text;
            string endereco = bunifuTextBox39.Text;
            string bairro = bunifuTextBox38.Text;
            string numero = bunifuTextBox37.Text;
            string cep = bunifuTextBox36.Text;
            string complemento = bunifuTextBox41.Text;
            string estado = bunifuTextBox40.Text;
            string escolaridade = bunifuTextBox42.Text;
            string filhos = bunifuDropdown5.Text;
            string pcd = bunifuDropdown6.Text;

            if(imagemBytes != null)
            {
                bool success = data.SaveImageInDatabase(imagemBytes, nomeCompleto);

                if(success)
                {
                    MessageBox.Show("Imagem salva!");
                }
                else
                {
                    MessageBox.Show("Deu merda");
                }
            }

           if (data.SearchFuncionario(nomeCompleto) == false)
            {
                bool success = data.InsertDataInDatabase(nomeCompleto, cpf, rg, email, dataNasc, reservista, tituloEleitor, celular, sexo, estadoCivil, dataAdmissao, cargo, funcao, salarioBase,
                        banco, agencia, cc, endereco, bairro, numero, cep, complemento, estado, escolaridade, filhos, pcd);
                if (success)
                {
                    MessageBox.Show("Dados atualizados com sucesso!");
                    Clear();
                }
                else
                {
                    MessageBox.Show("Erro ao atualizar dados.");
                }
            } 
            else
            {
                if (DataEdit())
                {
                    
                    bool success = data.UpdateDataInDatabase(nomeCompleto, cpf, rg, email, dataNasc, reservista, tituloEleitor, celular, sexo, estadoCivil, dataAdmissao, cargo, funcao, salarioBase,
                        banco, agencia, cc, endereco, bairro, numero, cep, complemento, estado, escolaridade, filhos, pcd);

                    if (success)
                    {
                        MessageBox.Show("Dados atualizados com sucesso!");
                        Clear();
                    }
                    else
                    {
                        MessageBox.Show("Erro ao atualizar dados.");
                    }
                }
                else
                {
                    MessageBox.Show("Nenhum dado foi alterado.");
                }
            }
        }

        private void bunifuButton12_Click_1(object sender, EventArgs e)
        {
            Clear();
            EnableControls();
        }

        private void DisableControls()
        {
            bunifuTextBox24.Enabled = false;
            bunifuTextBox23.Enabled = false;
            bunifuTextBox32.Enabled = false;
            bunifuTextBox29.Enabled = false;
            bunifuTextBox25.Enabled = false;
            bunifuTextBox26.Enabled = false;
            bunifuTextBox28.Enabled = false;
            bunifuDropdown4.Enabled = false;
            bunifuTextBox31.Enabled = false;
            bunifuTextBox35.Enabled = false;
            bunifuTextBox34.Enabled = false;
            bunifuTextBox33.Enabled = false;
            bunifuTextBox39.Enabled = false;
            bunifuTextBox38.Enabled = false;
            bunifuTextBox37.Enabled = false;
            bunifuTextBox36.Enabled = false;
            bunifuTextBox41.Enabled = false;
            bunifuTextBox40.Enabled = false;
            bunifuTextBox42.Enabled = false;
            bunifuDropdown5.Enabled = false;
            bunifuDropdown6.Enabled = false;
            bunifuTextBox30.Enabled = false;
            bunifuTextBox27.Enabled = false;
            bunifuDatePicker4.Enabled = false;
            bunifuDatePicker5.Enabled = false;
            bunifuDropdown3.Enabled = false;
        }

        private void EnableControls()
        {
            bunifuTextBox24.Enabled = false;
            bunifuTextBox23.Enabled = true;
            bunifuTextBox32.Enabled = true;
            bunifuTextBox29.Enabled = true;
            bunifuTextBox25.Enabled = true;
            bunifuTextBox26.Enabled = true;
            bunifuTextBox28.Enabled = true;
            bunifuDropdown4.Enabled = true;
            bunifuTextBox31.Enabled = true;
            bunifuTextBox35.Enabled = true;
            bunifuTextBox34.Enabled = true;
            bunifuTextBox33.Enabled = true;
            bunifuTextBox39.Enabled = true;
            bunifuTextBox38.Enabled = true;
            bunifuTextBox37.Enabled = true;
            bunifuTextBox36.Enabled = true;
            bunifuTextBox41.Enabled = true;
            bunifuTextBox40.Enabled = true;
            bunifuTextBox42.Enabled = true;
            bunifuDropdown5.Enabled = true;
            bunifuDropdown6.Enabled = true;
            bunifuTextBox30.Enabled = true;
            bunifuTextBox27.Enabled = true;
            bunifuDatePicker4.Enabled = true;
            bunifuDatePicker5.Enabled = true;
            bunifuDropdown3.Enabled = true;
        }

        private void Clear()
        {
            bunifuTextBox24.Text = "";
            bunifuTextBox23.Text = "";
            bunifuTextBox32.Text = "";
            bunifuTextBox29.Text = "";
            bunifuTextBox25.Text = "";
            bunifuTextBox26.Text = "";
            bunifuTextBox28.Text = "";
            bunifuDropdown4.Text = "";
            bunifuTextBox31.Text = "";
            bunifuTextBox35.Text = "";
            bunifuTextBox34.Text = "";
            bunifuTextBox33.Text = "";
            bunifuTextBox39.Text = "";
            bunifuTextBox38.Text = "";
            bunifuTextBox37.Text = "";
            bunifuTextBox36.Text = "";
            bunifuTextBox41.Text = "";
            bunifuTextBox40.Text = "";
            bunifuTextBox42.Text = "";
            bunifuDropdown5.Text = "";
            bunifuDropdown6.Text = "";
            bunifuTextBox30.Text = "";
            bunifuTextBox27.Text = "";
            bunifuDatePicker4.Text = "";
            bunifuDatePicker5.Text = "";
            bunifuDropdown3.Text = "";
        }

        private bool DataEdit()
        {
            return bunifuTextBox24.Text != data.NomeCompleto ||
                   bunifuTextBox23.Text != data.CPF ||
                   bunifuTextBox27.Text != data.RG ||
                   bunifuTextBox29.Text != data.Email ||
                   bunifuDatePicker4.Text != data.DataNasc ||
                   bunifuTextBox25.Text != data.Reservista ||
                   bunifuTextBox26.Text != data.TituloEleitor ||
                   bunifuTextBox28.Text != data.Celular ||
                   bunifuDropdown3.Text != data.Sexo ||
                   bunifuDropdown4.Text != data.EstadoCivil ||
                   bunifuDatePicker5.Text != data.DataAdmissao ||
                   bunifuTextBox32.Text != data.Cargo ||
                   bunifuTextBox31.Text != data.Funcao ||
                   bunifuTextBox30.Text != data.SalarioBase ||
                   bunifuTextBox35.Text != data.Banco ||
                   bunifuTextBox34.Text != data.Agencia ||
                   bunifuTextBox33.Text != data.CC ||
                   bunifuTextBox39.Text != data.Endereco ||
                   bunifuTextBox38.Text != data.Bairro ||
                   bunifuTextBox37.Text != data.Numero ||
                   bunifuTextBox36.Text != data.CEP ||
                   bunifuTextBox41.Text != data.Complemento ||
                   bunifuTextBox40.Text != data.Estado ||
                   bunifuTextBox42.Text != data.Escolaridade ||
                   bunifuDropdown5.Text != data.Filhos ||
                   bunifuDropdown6.Text != data.PCD;
        }

        private byte[] imagemBytes;

        private void bunifuButton30_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp; *.png)|*.jpg; *.jpeg; *.gif; *.bmp; *.png";


            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                bunifuPictureBox5.Image = new Bitmap(openFileDialog.FileName);

                using (MemoryStream ms = new MemoryStream())
                {
                    bunifuPictureBox5.Image.Save(ms, bunifuPictureBox5.Image.RawFormat);
                    imagemBytes = ms.ToArray();
                }
            }
        }
    }
}
