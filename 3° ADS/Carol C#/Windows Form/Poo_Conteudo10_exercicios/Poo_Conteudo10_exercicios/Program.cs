using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace Poo_Conteudo10_exercicios
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            string myValue =  Interaction.InputBox("Digite A para Exercício 1 \n" +
                                "Digite B para Execício 2","Excolha um exercício").ToString().ToUpper();
            if (myValue == "A")
            {
                Application.Run(new Exercico1());
            }
            else if (myValue == "B")
            {
                Application.Run(new Exercicio2());
            }
            else MessageBox.Show("O valor digitado não corresponde!","Erro",
                MessageBoxButtons.OK,MessageBoxIcon.Error);
        }
    }
}