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
    public partial class Exercicio2 : Form
    {
        public Exercicio2()
        {
            InitializeComponent();
        }

        private void btCalcular_Click(object sender, EventArgs e)
        {
            if (txtNomeFuncionario.Text != "" && 
                txtImposto.Text != "" &&
                txtSalario.Text != "" &&
                txtAumento.Text != "")
            {
                Funcionario execi2 = new Funcionario(txtNomeFuncionario.Text,Convert.ToDouble(txtSalario.Text.Replace(".", ",")),
                    Convert.ToDouble(txtImposto.Text.Replace(".",",")));

                String dados1 = execi2.SalarioLiquido().ToString();

                string dados2 = execi2.AumentarSalario(Convert.ToDouble(txtAumento.Text.Replace(".",",").Replace("%",""))).ToString();

                MessageBox.Show("O funcionário: " + execi2.Nome + ", vai receber R$ "+  dados1 +
                    "\n Vai receber com o aumento R$ "+ dados2);

                txtAumento.Text = "";
                txtImposto.Text = "";
                txtNomeFuncionario.Text = "";
                txtSalario.Text = "";
            }
            else
            {
                MessageBox.Show("Todos os campos devem ser preenchidos",
                    "Erro de preenchimento",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
    }
}
