using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Poo_Conteudo10_exercicios
{
    public class TxtNumeros:TextBox 
    {
         public static void Numeros(KeyPressEventArgs e)
        {

            //if(e.KeyChar != (char)Keys.Return)
            //{
            //    e.Handled = true;
            //}
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != ',') 
               e.Handled=true;
        }

    }
}
