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
    public partial class Form3 : Form
    {
        public Form3(int puntos)
        {
            InitializeComponent();
            this.puntos = puntos;
            this.Closing += new CancelEventHandler(Form3_Closing);
        }
        int puntos;

        void Form3_Closing(object sender, CancelEventArgs e)
        {
            e.Cancel = false;
            Application.Exit();
        }
        private void Form3_Load(object sender, EventArgs e)
        {
            lbl_final.Text =Convert.ToString(puntos);
            lbl_tiempo.Text = DateTime.Now.ToString();
        }
    }
}
