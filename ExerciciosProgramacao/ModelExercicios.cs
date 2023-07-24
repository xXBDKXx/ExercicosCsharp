using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosProgramacao
{
    class ModelExercicios
    {
        //Declarando uma Variavel
        private double num1;
        private double num2;

        //MEtodo Construtor
        public ModelExercicios()
        {
            getSetNum1 = 0;
            getSetNum2 = 0;
        }//Fim do Construtor

        //Metodos Get e Set
        public double getSetNum1
        {
            get { return this.num1; }
            set { this.num1 = value; }
        }// Fim do GetSet

        public double getSetNum2
        {
            get { return this.num2; }
            set { this.num2 = value; }
        }//Fim do GetSet

        public string DobroTriplo(double Num1)
        {
            string Result = "";
            Result = "O dobro do Numero: " + Num1 + " é: " + (Num1 * 2) + " e o Triplo é: " + (Num1 * 3);
            return Result;
        }//Fim do Metodo

        public string Salario30(double salario)
        {
            string Result = "";
            double valor = 0;

            valor = salario * 30 / 100;

            Result = "O Salario: " + salario + " Com o aumento de 30% é de: " + (salario + valor);
            return Result;
        }//Fim do Metodo

        public string ImparPar(double Valor)
        {
            string Result = "";

            Valor = Valor % 2;

            if (Valor % 2 == 0)
            {
                Result = "O valor digitado é Par";
                return Result;
            }
           return "O Valor digitado é Impar";

        }//Fim do Metodo

        public string PosNeg(double Valor) 
        {
            string PosNeg = ImparPar(Valor);
            string Result = "";
            
            if (Valor > 0)
            {
                Result = "O valor digitado é Positivo";
                return Result;
            }
            else
            {
                Result = "O Valor digitado é Negativo";
                return Result;
            }//Fim do IF e Else
        }//Fim do Metodo

        public string SomaUmCem()
        {
            int num = 0;

            for (int i = 0; i < 101; i++)
            {
                num += i;
            }//FIm do For

            return "O valor da Soma é de: " + num; 
        }//Fim do Metodo

        public string TabuadaNum(int num)
        {
            string resultado = "";

            for (int i = 0; i == num; i++)
            {
                resultado += "\n" + num + " * " + i + " = " + (num * i);
            }//Fim do For
            return resultado;
        }//Fim do Metodo Tabuada 

    }//Fim da Classe
}//Fim do Projeto
