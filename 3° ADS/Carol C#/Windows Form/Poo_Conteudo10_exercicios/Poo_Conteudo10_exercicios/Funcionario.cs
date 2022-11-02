using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Poo_Conteudo10_exercicios
{
    internal class Funcionario
    {
        private string nome;
        private double salarioBruto;
        private double imposto;
        private double salarioLiquido;
        private double salarioReajuste;
        public Funcionario(string nome, double salarioBruto, double imposto)
        {
            this.nome = nome;
            this.salarioBruto = salarioBruto;
            this.imposto = imposto;
            this.salarioLiquido = 0;
            this.salarioReajuste = 0;
        }
        public string Nome
        {
            get { return nome; }
        }
        public double SalarioLiquido()
        {
            this.salarioLiquido = this.salarioBruto - this.imposto;
            return this.salarioLiquido;
        }
        public double AumentarSalario(double porcentReajuste)
        {

            this.salarioReajuste = this.salarioLiquido + ((this.salarioBruto * porcentReajuste) / 100);
            return this.salarioReajuste;
        }
    }
}