using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Primeiro_Projeto_tela
{
    public partial class Tela_Login : Form
    {
        public Tela_Login()
        {
            InitializeComponent();
        }

        private void btSalvar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Nome guardado com sucesso " + txt_nome.Text, "Este é o titulo" );

            DialogResult retono = MessageBox.Show("Você gostou do sistema",
                "O titulo é bom?",
                MessageBoxButtons.YesNo);

            if (retono == DialogResult.Yes)
            {
                MessageBox.Show("Fico muito feliz com a sua informação");
            }
            else
            {
                MessageBox.Show("Vamos estudar mais????",
                    "Sistema novo",
                    MessageBoxButtons.YesNoCancel,
                    MessageBoxIcon.Error);
            }
        }

        private void Tela_Login_Load(object sender, EventArgs e)
        {

        }
    }
}
