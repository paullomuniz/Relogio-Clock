using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace relogio
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Color corFundo = Color.FromArgb(25, 47, 51);
            this.BackColor = corFundo;

            lbHoras.ForeColor = Color.White;
            lbMinutos.ForeColor = Color.White;
            lbSegundos.ForeColor = Color.White;
            lbData.ForeColor = Color.White;

            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbHoras.Text = DateTime.Now.ToString("HH");
            lbMinutos.Text = DateTime.Now.ToString("mm");
            lbSegundos.Text = DateTime.Now.ToString("ss") + " sec";

            int dia = Convert.ToInt32(DateTime.Now.ToString("dd"));
            int mes = Convert.ToInt32(DateTime.Now.ToString("MM"));
            int ano = Convert.ToInt32(DateTime.Now.ToString("yyyy"));

            DateTime dateValue = new DateTime(ano, mes, dia);
            string strDiaSemana = dateValue.ToString("ddddddddddd");

            lbData.Text = strDiaSemana + ", " + dia.ToString() + " " + DateTime.Now.ToString("MMMM");
        }
    }
}
