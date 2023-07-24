using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosProgramacao
{
    class ControlExercicos
    {
        //Criando o Objeto na Memoria
        ModelExercicios Exercicio = new ModelExercicios();


        public void Coletar()
        {
            Console.WriteLine("Informe um Numero: ");
            this.Exercicio.getSetNum1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Informe outro Numero: ");
            this.Exercicio.getSetNum2 = Convert.ToDouble(Console.ReadLine());
        }//Fim do Coletar

        public int Menu()
        {
            Console.WriteLine("-----Menu-----" +
                              "\n1.Dobrar e Triplicar " +
                              "\n2.Salario com Aumento 30%" +
                              "\n3.Impar Par | Positio Negativo" +
                              "\n4.Soma dos Numeros de 1 a 100" +
                              "\n5.Tabuada de ate N" +
                              "\n0.Sair " +
                              "\n\nEscolha uma das opções acima: ");

            int opcao = Convert.ToInt32(Console.ReadLine());
            return opcao;
        }//Fim do Metodo Menu

        public void Operacao()
        {
            int opcao = -1;
            do
            {
                opcao = Menu();
                Console.Clear();
                switch (opcao)
                {
                    case 0:
                        Console.WriteLine("Obrigado");
                        break;

                    case 1:
                        Console.WriteLine("Informe um numero:");
                        double Num1 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine(this.Exercicio.DobroTriplo(Num1));
                        break;
                    case 2:
                        Console.WriteLine("Informe seu salario:");
                        double salario = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine(this.Exercicio.Salario30(salario));
                        break;
                    case 3:
                        Console.WriteLine("Informe um numero:");
                        double Valor = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine(this.Exercicio.ImparPar(Valor));
                        Console.WriteLine(this.Exercicio.PosNeg(Valor));
                        break;
                    case 4:
                        Console.WriteLine(this.Exercicio.SomaUmCem());
                        break;
                    case 5:
                        Console.WriteLine("Informe um Numero: ");
                        int num = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine(this.Exercicio.TabuadaNum(num));
                        break;
                    default:
                        Console.WriteLine("Opção Invalida");
                        break;
                }//Fim do Switch
            } while (opcao != 0);
        }//Fim do Metodo
    }//Fim da Classse
}//Fim do Projeto
