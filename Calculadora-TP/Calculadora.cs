using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora_TP
{
    class Calculadora
    {
        //Esta classe define o que a calculadora deve fazer

        //Estes são os atributos que a nossa classe Calculadora têm para fazer qualquer conta.
        //n1 equivale ao primeiro número da conta e n2 ao segundo.
        double n1;
        double n2;

        //Estes são os valores encapsulados.
        public double N1 { get => n1; set => n1 = value; }
        public double N2 { get => n2; set => n2 = value; }


        //A classe calculadora efetua as contas recebendo os valores de n1 e n2 do formulário
        //depois de receber os valores o método Soma() é capaz de somar os valores armazenados no objeto soma e retornar o resultado da soma.
        public double Soma()
        {
            double soma = this.N1 + this.N2;
            return (soma);
        }

        public double Subtrai()
        {
            double subtr = this.N1 - this.N2;
            return (subtr);
        }


        public double Div()
        {
                double div = this.N1 / this.N2;
                return (div);            
        }



        public double Multiplica()
        {
            double resultado = this.n1 * this.n2;
            return (resultado);
        }


        public double Mult()
        {
            return (this.n1 * this.n2);
        }



        public double Expo()
        {
            double resultado = Math.Pow(this.N1, this.N2);
            return (resultado);

        }

        public double Exp()
        {
            return (Math.Pow(this.N1, this.N2));

        }





        public double exp()
        {
            double exp = Math.Pow(this.N1, this.N2);
            return exp;
        }
        
    }
}
