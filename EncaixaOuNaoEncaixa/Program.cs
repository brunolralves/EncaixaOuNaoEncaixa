using System.IO;
using System.Linq;
using System;

class DIO
{
    /* 
     QUESTÃO
     Paulinho tem em suas mãos um novo problema. Agora a sua professora lhe pediu que 
     construísse um programa para verificar, à partir de dois valores muito grandes 
     A e B, se B corresponde aos últimos dígitos de A.
     ENTRADA
     A entrada consiste de vários casos de teste. A primeira linha de entrada contém um 
     inteiro N que indica a quantidade de casos de teste. Cada caso de teste consiste de 
     dois valores A e B maiores que zero, cada um deles podendo ter até 1000 dígitos.
 
     SAÍDA
     Para cada caso de entrada imprima uma mensagem indicando se o segundo valor encaixa 
     no primeiro valor, confome exemplo abaixo.
    */

    static void Main(string[] args)
    {
        int qt = int.Parse(Console.ReadLine());


        bool validador = false;
        for (int i = 0; i < qt; i++)
        {
            string num = Console.ReadLine();
            string[] v = num.Split(' ');
            string a = v[0];
            string b = v[1];


            int n = 1;
            for (int j = b.Length; j > 0; j--)
            {

                if ((b.Length > a.Length))
                {
                    validador = false;
                    break;

                }
                else if ((b[j - 1] == a[a.Length - n]))
                {
                    validador = true;
                    
                }
                else
                {
                    validador = false;
                    break;
                }
                n++;
            }


            if (validador)
                Console.WriteLine("encaixa");
            else
                Console.WriteLine("nao encaixa");

        }
    }
}