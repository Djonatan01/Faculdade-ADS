using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Poo_Conteudo10_exercicios
{
    internal static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            DialogResult retono = MessageBox.Show("SIM = Para exrcício 1  \n" +
                "Não = para exrcício 2 ","Opção de esclolha",MessageBoxButtons.YesNoCancel); 
            if(retono == DialogResult.Yes) { 
                Application.Run(new Exercico1());
            }
            else
            {
                Application.Run(new Exercicio2() );
            }
        }
    }
}
