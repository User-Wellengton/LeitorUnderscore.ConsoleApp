using System;
using System.IO;

namespace LeitorUnderscore
{

    internal class Program
    {
        static void Main(string[] args)
        {

            string linhaUm = "";
            string linhaDois = "";
            string linhatres = "";

            string numero = @" __      __  __      __  __  __  __  __ 
                              |  |   | __| __||__||__ |__    ||__||__|
                              |__|   ||__  __|   | __||__|   ||__| __|";

            StringReader leitorDeCodigo = new StringReader(numero);

            string primeiraLinha = leitorDeCodigo.ReadLine();

            string segundaLinha = leitorDeCodigo.ReadLine();

            string terceiraLinha = leitorDeCodigo.ReadLine();

            segundaLinha = segundaLinha.Trim();
            terceiraLinha = terceiraLinha.Trim();


            char[] posicaoPrimeiraLinha = primeiraLinha.ToCharArray();
            char[] posicaoSegundaLinha = segundaLinha.ToCharArray();
            char[] posicaoTerceiraLinha = terceiraLinha.ToCharArray();



            int contadorDePosicoes = 0;


            for (int coluna = 0; coluna < 40; coluna++)
            {
                linhaUm += posicaoPrimeiraLinha[coluna];
                linhaDois += posicaoSegundaLinha[coluna];
                linhatres += posicaoTerceiraLinha[coluna];


                if (linhaUm == " __ " && linhaDois == "|  |" && linhatres == "|__|") // VERIFICAÇÃO 0
                {
                    Console.Write("0");
                }

                if (linhaUm == "    " && linhaDois == "   |" && linhatres == "   |")// VERIFICAÇÃO 1
                {
                    Console.Write("1");
                }

                if (linhaUm == " __ " && linhaDois == " __|" && linhatres == "|__ ")// VERIFICAÇÃO 2
                {
                    Console.Write("2");
                }

                if (linhaUm == " __ " && linhaDois == " __|" && linhatres == " __|")// VERIFICAÇÃO 3
                {
                    Console.Write("3");
                }

                if (linhaUm == "    " && linhaDois == "|__|" && linhatres == "   |")// VERIFICAÇÃO 4
                {
                    Console.Write("4");
                }

                if (linhaUm == " __ " && linhaDois == "|__ " && linhatres == " __|")// VERIFICAÇÃO 5
                {
                    Console.Write("5");
                }

                if (linhaUm == " __ " && linhaDois == "|__ " && linhatres == "|__|")// VERIFICAÇÃO 6
                {
                    Console.Write("6");
                }

                if (linhaUm == " __ " && linhaDois == "   |" && linhatres == "   |")// VERIFICAÇÃO 7
                {
                    Console.Write("7");
                }

                if (linhaUm == " __ " && linhaDois == "|__|" && linhatres == "|__|")// VERIFICAÇÃO 8
                {
                    Console.Write("8");
                }

                if (linhaUm == " __ " && linhaDois == "|__|" && linhatres == " __|")// VERIFICAÇÃO 9
                {
                    Console.Write("9");
                }

                contadorDePosicoes++;

                if (contadorDePosicoes == 4)
                {
                    linhaUm = "";
                    linhaDois = "";
                    linhatres = "";

                    contadorDePosicoes = 0;
                }


                

            }


            Console.ReadLine();




        }
    }
}
