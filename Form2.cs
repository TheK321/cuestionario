using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cuestionario
{
    public partial class Form2 : Form
    {
        public Form2(int puntos)
        {
            InitializeComponent();
            this.puntos = puntos;
        }
        int puntos;
        private void Form2_Load(object sender, EventArgs e)
        {
            lbl_valor.Text =Convert.ToString(puntos);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton2.Checked == true)
            {
                puntos += 50;
                MessageBox.Show("Has ganado " + puntos + " puntos");
            }
            else
            {
                MessageBox.Show("La respuesta correcta era Peña");
            }
            Form3 frm3 = new Form3(puntos);
            frm3.Show();
            this.Hide();
        }
    }
}
