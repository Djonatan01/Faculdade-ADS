using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Poo_Conteudo10_exercicios
{
    public partial class Exercico1 : Form
    {
        public Exercico1()
        {
            InitializeComponent();
        }

        private void btArea_Click(object sender, EventArgs e)
        {
            lbArea.Text = "";
            lbDiagonal.Text = "";
            lbPerimetro.Text = "";

            Exe1 exerc1 = new Exe1();
            lbArea.Text = "Total da área é {0:F2}" + Convert.ToString(+
                exerc1.getArea(Convert.ToDouble(txt_Largura.Text),+
                Convert.ToDouble(txt_altura.Text)));


            lbDiagonal.Text = "";
            lbPerimetro.Text = "";

        }

        private void btPerimetro_Click(object sender, EventArgs e)
        {

            lbArea.Text = "";
            lbDiagonal.Text = "";
            lbPerimetro.Text = "";

            Exe1 exerc1 = new Exe1();
            lbPerimetro.Text = "Total da perímetro é " + Convert.ToString(+
                exerc1.getPerimetro(Convert.ToDouble(txt_Largura.Text), +
                Convert.ToDouble(txt_altura.Text)));

            lbDiagonal.Text = "";
            lbArea.Text = "";
        }

        private void btDiagonal_Click(object sender, EventArgs e)
        {

            lbArea.Text = "";
            lbDiagonal.Text = "";
            lbPerimetro.Text = "";

            Exe1 exerc1 = new Exe1();
            lbDiagonal.Text = ("Total da diagonal é {0:F2}" + 
                exerc1.getDiagonal(Convert.ToDouble(txt_Largura.Text), +
                Convert.ToDouble(txt_altura.Text)));

            lbPerimetro.Text = "";
            lbArea.Text = "";
        }

        private void Exercico1_Load(object sender, EventArgs e)
        {
            txt_altura.Text = "";
            txt_Largura.Text = "";
            lbArea.Text = "";
            lbDiagonal.Text = "";
            lbPerimetro.Text = "";
        }
    }
}
