using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Windows_Forms_DeskTop
{
    public partial class folha_Pagamento : Form
    {
        public folha_Pagamento()
        {
            InitializeComponent();
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {
            dataGridView_Employees.Rows.Add(new object[] {1,"Kelvy Tagliacolli" });
        }

        private void folha_Pagamento_Load(object sender, EventArgs e)
        {
            dataGridView_info.Rows.Add(new object[] { "[1]", "Salário base", "0,00", "1.900" });
            dataGridView_info.Rows.Add(new object[] { "[2]", "Vale Transporte", "*22" , "", "120,00" });
            dataGridView_info.Rows.Add(new object[] { "[3]", "INSS", "*7,5", "", "142,50" });
            dataGridView_info.Rows.Add(new object[] { "[4]", "FGTS", "*8.0", "161.50", "" });
            dataGridView_info.Rows.Add(new object[] { "[5]", "hora extra", "50%", "19,43", "" });
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
