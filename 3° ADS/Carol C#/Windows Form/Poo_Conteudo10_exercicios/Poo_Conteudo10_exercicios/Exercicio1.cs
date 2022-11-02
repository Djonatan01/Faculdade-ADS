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
            if (txt_altura.Text != "" && txt_Largura.Text != "") { 
            lbArea.Text = "";
            lbDiagonal.Text = "";
            lbPerimetro.Text = "";
                
                Retangulo exerc1 = new Retangulo(Convert.ToDouble(txt_altura.Text), Convert.ToDouble(txt_Largura.Text));

                lbArea.Text = "A área é \n" + exerc1.getArea().ToString("F2");

            lbDiagonal.Text = "";
            lbPerimetro.Text = "";

            }
            else
            {
                MessageBox.Show("Altura ou Lagura não foi preenchido!",
                                "Digitação",MessageBoxButtons.OK, 
                                MessageBoxIcon.Error);
            }

        }

        private void btPerimetro_Click(object sender, EventArgs e)
        {
            if (txt_altura.Text != "" && txt_Largura.Text != "") { 
            
                lbArea.Text = "";
                lbDiagonal.Text = "";
                lbPerimetro.Text = "";

                Retangulo exerc1 = new Retangulo(Convert.ToDouble(txt_altura.Text), Convert.ToDouble(txt_Largura.Text));

                lbPerimetro.Text = "A perímetro é \n" + exerc1.getPerimetro().ToString("F2");
                lbDiagonal.Text = "";
                lbArea.Text = "";
            }
            else
            {
                MessageBox.Show("Altura ou Lagura não foi preenchido!",
                                "Digitação", MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }

        private void btDiagonal_Click(object sender, EventArgs e)
        {
            if (txt_altura.Text != "" && txt_Largura.Text != "")
            {
                lbArea.Text = "";
            lbDiagonal.Text = "";
            lbPerimetro.Text = "";

            Retangulo exerc1 = new Retangulo(Convert.ToDouble(txt_altura.Text),Convert.ToDouble(txt_Largura.Text));

            lbDiagonal.Text = "A diagonal é \n"+exerc1.getDiagonal().ToString("F2");                

            lbPerimetro.Text = "";
            lbArea.Text = "";
            }
            else
            {
                MessageBox.Show("Altura ou Lagura não foi preenchido!",
                                "Digitação", MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }

        private void Exercico1_Load(object sender, EventArgs e)
        {
            txt_altura.Text = "";
            txt_Largura.Text = "";
            lbArea.Text = "";
            lbDiagonal.Text = "";
            lbPerimetro.Text = "";
        }

        private void txt_Largura_KeyPress(object sender, KeyPressEventArgs e)
        {
            TxtNumeros.Numeros(e);
        }

        private void txt_altura_KeyPress(object sender, KeyPressEventArgs e)
        {
            TxtNumeros.Numeros(e);
        }
    }
}

