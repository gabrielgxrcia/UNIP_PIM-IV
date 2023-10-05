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
    public partial class horaExtra : Form
    {
        public horaExtra()
        {
            InitializeComponent();
        }

        public void panel_Employees_Paint(object sender, PaintEventArgs e)
        {
            var Employee2 = new List<string>();
            {
                Employee2.Add("1");
                Employee2.Add("Kelvy Tagliacolli");
            }
            dataGridView_Employees.Rows.Add(Employee2[0], Employee2[1]);
        }

        private void panel_Form_Paint(object sender, PaintEventArgs e)
        {
            var Date11_05 = new List<string>(); 
            {
                Date11_05.Add("11 / 05" + " | " + "Qui");
                Date11_05.Add("Normal");
                Date11_05.Add("8:00");
                Date11_05.Add("12:00" + " | " + "13:00");
                Date11_05.Add("18:00");
                Date11_05.Add("10:00");
                Date11_05.Add("00:00");
                Date11_05.Add("00:00");
            }

            dataGridView_Time.Rows.Add(Date11_05[0], Date11_05[1], Date11_05[2], Date11_05[3], Date11_05[4]);

            var Date12_05 = new List<string>();
            {
                Date12_05.Add("12 / 05" + " | " + "Sex");
                Date12_05.Add("Normal");
                Date12_05.Add("8:00");
                Date12_05.Add("12:00" + " | " + "13:00");
                Date12_05.Add("17:00");
                Date12_05.Add("09:00");
                Date12_05.Add("00:00");
                Date12_05.Add("00:00");
                Date12_05.Add("00:00");
            }

            dataGridView_Time.Rows.Add(Date12_05[0], Date12_05[1], Date12_05[2], Date12_05[3], Date12_05[4]);

            var Date13_05 = new List<string>();
            {
                Date13_05.Add("13 / 05" + " | " + "Sab");
                Date13_05.Add("Folga");
                Date13_05.Add("");
                Date13_05.Add("" + " | " + "");
                Date13_05.Add("");
                Date13_05.Add("00:00");
                Date13_05.Add("00:00");
                Date13_05.Add("00:00");
            }

            dataGridView_Time.Rows.Add(Date13_05[0], Date13_05[1], Date13_05[2], Date13_05[3], Date13_05[4]);

            var Date14_05 = new List<string>();
            {
                Date14_05.Add("14 / 05" + " | " + "Dom");
                Date14_05.Add("Folga");
                Date14_05.Add("");
                Date14_05.Add("" + " | " + "");
                Date14_05.Add("");
                Date14_05.Add("00:00");
                Date14_05.Add("00:00");
                Date14_05.Add("00:00");
            }

            dataGridView_Time.Rows.Add(Date14_05[0], Date14_05[1], Date14_05[2], Date14_05[3], Date14_05[4]);

            var Date15_05 = new List<string>();
            {
                Date15_05.Add("15 / 05" + " | " + "Seg");
                Date15_05.Add("Normal");
                Date15_05.Add("8:00");
                Date15_05.Add("12:00" + " | " + "13:00");
                Date15_05.Add("18:00");
                Date15_05.Add("10:00");
                Date15_05.Add("00:00");
                Date15_05.Add("00:00");
            }

            dataGridView_Time.Rows.Add(Date15_05[0], Date15_05[1], Date15_05[2], Date15_05[3], Date15_05[4]);

            var Date16_05 = new List<string>();
            {
                Date16_05.Add("16 / 05" + " | " + "Ter");
                Date16_05.Add("Normal");
                Date16_05.Add("8:00");
                Date16_05.Add("12:00" + " | " + "13:00");
                Date16_05.Add("17:00");
                Date16_05.Add("09:00");
                Date16_05.Add("01:00");
                Date16_05.Add("00:00");
            }

            dataGridView_Time.Rows.Add(Date16_05[0], Date16_05[1], Date16_05[2], Date16_05[3], Date16_05[4]);

            var Date17_05 = new List<string>();
            {
                Date17_05.Add("17 / 05" + " | " + "Qua");
                Date17_05.Add("Normal");
                Date17_05.Add("8:00");
                Date17_05.Add("12:00" + " | " + "13:00");
                Date17_05.Add("18:00");
                Date17_05.Add("10:00");
                Date17_05.Add("00:00");
                Date17_05.Add("00:00");
            }

            dataGridView_Time.Rows.Add(Date17_05[0], Date17_05[1], Date17_05[2], Date17_05[3], Date17_05[4]);

            var Date18_05 = new List<string>();
            { 
                Date18_05.Add("18 / 05" + " | " + "Qui");
                Date18_05.Add("Normal");
                Date18_05.Add("8:00");
                Date18_05.Add("12:00" + " | " + "13:00");
                Date18_05.Add("19:00");
                Date18_05.Add("11:00");
                Date18_05.Add("00:00");
                Date18_05.Add("01:00");
            }

            dataGridView_Time.Rows.Add(Date18_05[0], Date18_05[1], Date18_05[2], Date18_05[3], Date18_05[4]);

            var Date19_05 = new List<string>();
            {
                Date19_05.Add("19 / 05" + " | " + "Sex");
                Date19_05.Add("Normal");
                Date19_05.Add("8:00");
                Date19_05.Add("12:00" + " | " + "13:00");
                Date19_05.Add("17:00");
                Date19_05.Add("09:00");
                Date19_05.Add("00:00");
                Date19_05.Add("00:00");
            }

            dataGridView_Time.Rows.Add(Date19_05[0], Date19_05[1], Date19_05[2], Date19_05[3], Date19_05[4]);

            var Date20_05 = new List<string>();
            {
                Date20_05.Add("20 / 05" + " | " + "Sab");
                Date20_05.Add("Folga");
                Date20_05.Add("");
                Date20_05.Add("" + " | " + "");
                Date20_05.Add("");
                Date20_05.Add("00:00");
                Date20_05.Add("00:00");
                Date20_05.Add("00:00");
            }

            dataGridView_Time.Rows.Add(Date20_05[0], Date20_05[1], Date20_05[2], Date20_05[3], Date20_05[4]);

            var Date21_05 = new List<string>();
            {
                Date21_05.Add("21 / 05" + " | " + "Dom");
                Date21_05.Add("Folga");
                Date21_05.Add("");
                Date21_05.Add("" + " | " + "");
                Date21_05.Add("");
                Date21_05.Add("00:00");
                Date21_05.Add("00:00");
                Date21_05.Add("00:00");
            }

            dataGridView_Time.Rows.Add(Date21_05[0], Date21_05[1], Date21_05[2], Date21_05[3], Date21_05[4]);

            var Date22_05 = new List<string>();
            {
                Date22_05.Add("22 / 05" + " | " + "Seg");
                Date22_05.Add("Normal");
                Date22_05.Add("8:00");
                Date22_05.Add("12:00" + " | " + "13:00");
                Date22_05.Add("19:00");
                Date22_05.Add("11:00");
                Date22_05.Add("00:00");
                Date22_05.Add("01:00");
            }

            dataGridView_Time.Rows.Add(Date22_05[0], Date22_05[1], Date22_05[2], Date22_05[3], Date22_05[4]);
            //
            // Horas de Trabalho //
            //
            dataGrid_Horas_trabalhadas.Rows.Add(Date11_05[5]);
            dataGrid_Horas_trabalhadas.Rows.Add(Date12_05[5]); 
            dataGrid_Horas_trabalhadas.Rows.Add(Date13_05[5]);
            dataGrid_Horas_trabalhadas.Rows.Add(Date14_05[5]);
            dataGrid_Horas_trabalhadas.Rows.Add(Date15_05[5]);
            dataGrid_Horas_trabalhadas.Rows.Add(Date16_05[5]);
            dataGrid_Horas_trabalhadas.Rows.Add(Date17_05[5]);
            dataGrid_Horas_trabalhadas.Rows.Add(Date18_05[5]);
            dataGrid_Horas_trabalhadas.Rows.Add(Date19_05[5]);
            dataGrid_Horas_trabalhadas.Rows.Add(Date20_05[5]);
            dataGrid_Horas_trabalhadas.Rows.Add(Date21_05[5]);
            dataGrid_Horas_trabalhadas.Rows.Add(Date22_05[5]);
            //
            // Horas Devidas /
            //
            dataGrid_horas_devidas.Rows.Add(Date11_05[6]);
            dataGrid_horas_devidas.Rows.Add(Date12_05[6]);
            dataGrid_horas_devidas.Rows.Add(Date13_05[6]);
            dataGrid_horas_devidas.Rows.Add(Date14_05[6]);
            dataGrid_horas_devidas.Rows.Add(Date15_05[6]);
            dataGrid_horas_devidas.Rows.Add(Date16_05[6]);
            dataGrid_horas_devidas.Rows.Add(Date17_05[6]);
            dataGrid_horas_devidas.Rows.Add(Date18_05[6]);
            dataGrid_horas_devidas.Rows.Add(Date19_05[6]);
            dataGrid_horas_devidas.Rows.Add(Date20_05[6]);
            dataGrid_horas_devidas.Rows.Add(Date21_05[6]);
            dataGrid_horas_devidas.Rows.Add(Date22_05[6]);
            //
            // Horas Extras
            //
            dataGrid_horas_extras.Rows.Add(Date11_05[7]);
            dataGrid_horas_extras.Rows.Add(Date12_05[7]);
            dataGrid_horas_extras.Rows.Add(Date13_05[7]);
            dataGrid_horas_extras.Rows.Add(Date14_05[7]);
            dataGrid_horas_extras.Rows.Add(Date15_05[7]);
            dataGrid_horas_extras.Rows.Add(Date16_05[7]);
            dataGrid_horas_extras.Rows.Add(Date17_05[7]);
            dataGrid_horas_extras.Rows.Add(Date18_05[7]);
            dataGrid_horas_extras.Rows.Add(Date19_05[7]);
            dataGrid_horas_extras.Rows.Add(Date20_05[7]);
            dataGrid_horas_extras.Rows.Add(Date21_05[7]);
            dataGrid_horas_extras.Rows.Add(Date22_05[7]);
        }

        private void button_close_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
