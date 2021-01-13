using System;
using System.Collections.Specialized;
using System.Text;

namespace Algoritmo1
{
    class Program
    {
        static void Main(string[] args)
        {
            //EXERCÍCIO 1:

            //Console.WriteLine("DIGITE A PRIMEIRA NOTA:");
            //double nota1 = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("DIGITE A SEGUNDA NOTA:");
            //double nota2 = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("DIGITE A TERCEIRA NOTA:");
            //double nota3 = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("DIGITE A QUARTA NOTA:");
            //double nota4 = Convert.ToDouble(Console.ReadLine());
            //double media = ((nota1 + nota2 + nota3 + nota4) / 4);
            //Console.WriteLine("SUA NOTA FINAL É:" + " " + (media));
            //if (media <= 6.9)
            //{
            //    Console.WriteLine("REPROVADO!");
            //}
            //else
            //{
            //    Console.WriteLine("APROVADO!");
            //}


            //EXERCÍCIO 2:

            //Console.WriteLine("Digite a distância(Km):");
            //double distancia = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("Digite a velocidade(Km/h):");
            //double velocidade = Convert.ToDouble(Console.ReadLine());
            //double tempo = distancia / velocidade;
            //Console.WriteLine($"Você chegará ao seu destino em {tempo} horas:");


            //EXERCÍCIO 3:

    //        int maxTentativas = 15;
    //        string palavra = "DESENVOLVEDOR";
    //        int qtdeCaracteres = palavra.Length;
    //        string segredo = "";
    //        int letrasAcertadas = 0;

    //        for (int i = 0; i < qtdeCaracteres; i++)
    //        {
    //            segredo = segredo + "_ ";
    //        }

    //        string letra = "";

    //        for (int i = 0; i < maxTentativas; i++)
    //        {
    //            if (letrasAcertadas == palavra.Length)
    //            {
    //                Console.WriteLine("Parabéns! Você salvou seu pescoço!");
    //                break;
    //            }

    //            Console.WriteLine(segredo);
    //            Console.WriteLine("Informe uma letra:");
    //            letra = Console.ReadLine();
    //            letra = letra.ToUpper();

    //            if (letra.Length == 1)
    //            {
    //                int qtdeEspacos = 0;

    //                for (int l = 0; l < qtdeCaracteres; l++)
    //                {
    //                    string letter = palavra.Substring(l, 1);

    //                    if (l != 0)
    //                        qtdeEspacos++;

    //                    if (letter == letra)
    //                    {
    //                        letrasAcertadas++;

    //                        int indexSubString;

    //                        if (l == 0)
    //                            indexSubString = l;
    //                        else
    //                            indexSubString = l + qtdeEspacos;

    //                        StringBuilder sb = new StringBuilder(segredo);
    //                        sb[indexSubString] = Convert.ToChar(letter);
    //                        segredo = sb.ToString();
    //                    }
    //                }
    //            }
    //            else
    //            {
    //                if (letra.ToLower() == palavra.ToLower())
    //                {
    //                    letrasAcertadas = palavra.Length;
    //                    Console.WriteLine("Parabéns! Você salvou seu pescoço!");
    //                    break;
    //                }
    //            }
    //}

    //        if (letrasAcertadas != palavra.Length)
    //        {
    //            Console.WriteLine("Fim de jogo: você foi enforcado!");
    //        }

        }
    }
}
