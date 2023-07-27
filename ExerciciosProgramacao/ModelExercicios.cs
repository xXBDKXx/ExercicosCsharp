using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosProgramacao
{
    class ModelExercicios
    {
        //Declarando uma Variavel
        private int num1;
        private int num2;

        //MEtodo Construtor
        public ModelExercicios()
        {
            getSetNum1 = 0;
            getSetNum2 = 0;
        }//Fim do Construtor

        //Metodos Get e Set
        public int getSetNum1
        {
            get { return this.num1; }
            set { this.num1 = value; }
        }// Fim do GetSet

        public int getSetNum2
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

            for (int i = 0; i <= num; i++)
            {
                resultado += "\n" + num + " * " + i + " = " + (num * i);
            }//Fim do For
            return resultado;
        }//Fim do Metodo Tabuada 

        public string NumUmToNumDois()
        {
            string resultado = "";

            for (int i = getSetNum1; i <= getSetNum2; i++) 
            {
                resultado += "\n" + i;
            }//Fim do For
            return resultado;
        }//Fim do Metodo

        public string NumImparCemAteDuzentos()
        {
            string resultado = "";

            for (int i = 100; i <= 200; i++)
            {
                if (i % 2 == 1)
                {
                    resultado += "-" + i;
                }//Fim do If
            }//Fim do For
            return resultado;
        }//Fim do Metodo

        public string SomaDeDezNumeros()
        {
            int n = 0;
            int soma = 0;
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("Digite o " + i + "° Numero: ");
                n = Convert.ToInt32(Console.ReadLine());
                soma = soma + n;
            }//Fim do For
            return "A soma dos Dez numeros digitados é de: " + soma;
        }//Fim do metodo

        public string SomaDeNValores()
        {
            int n = 1;
            int soma = 0;
            do
            {
                Console.WriteLine("Digite Numeros: ");
                n = Convert.ToInt32(Console.ReadLine());
                soma = soma + n;
            } while (n != 0);
            return "A soma de todos os valores digitados é de: " + soma;
        }//Fim do metodo

        public string MediaDePares()
        {
            int i = 0;
            int n = 1;
            int soma = 0;
            do
            {
                Console.WriteLine("Digite Numeros: ");
                n = Convert.ToInt32(Console.ReadLine());
                if (n % 2 == 0)
                {
                    soma = soma + n;
                    i += 1;
                }//Fim do IF
            } while (n != 0);
            return "A Media de todos os valores digitados que são pares é de: " + (soma / (i-1));
        }//fim do Metodo

        public string MaiorEMenorValor()
        {
            int n = 1;
            int a = 1;
            int b = 1;
            Boolean flag = false;
            do
            {
                Console.WriteLine("Digite Numeros: ");
                n = Convert.ToInt32(Console.ReadLine());
                if(flag == false)
                {
                    a = n;
                    b = n;
                    flag = true;
                }//FIm do IF

                if (n != 0)
                {
                    if (n > a)
                    {
                        a = n;
                    }//Fim do IF
                    else if (n < a)
                    {
                        b = n;
                    }//Fim do Else if
                }//Fim do IF
            } while (n != 0);
            return "O Maior valor digitado foi: " + a + "\nO Menor valor digitado foi: " + b;
        }//Fim do Metodo

        public string VinteValores()
        {
            int n = 0;
            int soma = 0;
            int a = 0;
            for (int i = 1; i <= 20; i++)
            {
                Console.WriteLine("Digite o " + i + "° Numero: ");
                n = Convert.ToInt32(Console.ReadLine());
                if (n != 0)
                {
                    if (n > 0)
                    {
                        soma = soma + n;
                    }//Fim do IF
                    else if (n < 0)
                    {
                        a += 1;
                    }//Fim do Else if
                }//Fim do IF
            }//Fim do For
            return "A soma dos numeros positivos que foram digitados é de: " + soma + "\n E a quantia de valores negativos que foram digitados é de: " + a;
        }//Fim do metodo



    }//Fim da Classe
}//Fim do Projeto
