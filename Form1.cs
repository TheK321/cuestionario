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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int puntos;
        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                puntos += 50;
                MessageBox.Show("Has ganado " + puntos + " puntos");
            }
            else
            {
                MessageBox.Show("La respuesta correcta era México");
            }
            Form2 frm2 = new Form2(puntos);
            frm2.Show();
            this.Hide();
        }
    }
}
