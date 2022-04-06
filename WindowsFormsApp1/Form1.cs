using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.clientews;
using WindowsFormsApp1.modelo;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private async void button1_Click(object sender, EventArgs e)
        {
    
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            toolStripProgressBar1.Visible = true;
            //button1.Enabled = false;
            pictureBox1.Visible = true;
            var resultado = await UFWS.obtener();
            ModeloGlobal.UFActual = resultado.serie[0].valor;
            label1.Text = resultado.serie[0].valor.ToString();
            pictureBox1.Visible = false;
            //button1.Enabled = true;
            toolStripProgressBar1.Visible = false;
        }
    }
}
