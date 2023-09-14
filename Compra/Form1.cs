using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Compra
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int estoque = Convert.ToInt32(txtEstoque.Text);
            int min = Convert.ToInt32(txtMin.Text);
            int max = Convert.ToInt32(txtMax.Text);

            if (estoque == max)
            {
                lblCompra.Text = "0";
                picOk.Visible = true;
                picMedio.Visible = false;
                picAlerta.Visible = false;
                lblResposta.Text = "Tudo certo!";
            } else if (estoque < max && estoque > min )
            {
                lblResposta.Text = "Cuidado ai!!!";
                int res = max - estoque;
                lblCompra.Text = Convert.ToString(res);
                picMedio.Visible = true;
                picOk.Visible = false;
                picAlerta.Visible = false;
            } else if (estoque < min)
            {
                lblResposta.Text = "COMPRA URGENTE!";
                int res = max - estoque;
                lblCompra.Text = Convert.ToString(res);
                picAlerta.Visible = true;
                picMedio.Visible = false; 
                picOk.Visible = false;
            }
            else
            {
                lblResposta.Text = "EXCESO DE ESTOQUE!";
                lblCompra.Text = "X";
                picAlerta.Visible = true;
                picMedio.Visible = false;
                picOk.Visible = false;
            }

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            picMedio.Visible = false;
            picOk.Visible = false;
            picAlerta.Visible = false;
            lblResposta.Text = "";
            lblCompra.Text = "";
            txtEstoque.Text = "";
            txtMax.Text = "";
            txtMin.Text = "";

        }
    }
}
