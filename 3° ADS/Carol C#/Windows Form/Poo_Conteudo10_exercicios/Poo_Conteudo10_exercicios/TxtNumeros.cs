using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Poo_Conteudo10_exercicios
{
    public class TxtNumeros
    {
         public static void Numeros(KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8) 
                e.Handled=true;
        }

    }
}
