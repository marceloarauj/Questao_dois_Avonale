using System;

namespace Questao_dois_Avonale
{
    //PROJETO REFERENTE À QUESTÃO 2 DA PROVA - AVONALE
     
    class Program
    {
        static void Main(string[] args)
        {
            // lista para o item 1
            double[] elemntsQ1 = new double[]{20,20,90,10,80};

            // lista para o item 2
            string[] elemntsQ2 = new string[] { "A", "B", "C", "D","E","F","G" };
            
            // resultado do item 1                
            Console.WriteLine(" . Média Aritmética: "+
                        questaoDoisPontoUm(elemntsQ1, elemntsQ1.Length, elemntsQ1.Length));

            //resultado do item 2
            string[] listaInversa = questaoDoisPontoDois(elemntsQ2,elemntsQ2.Length,elemntsQ2.Length);

            Console.Write("Questão 2, ITEM 2: [");

            for (int i =0; i < listaInversa.Length; i++)
            {
                Console.Write(listaInversa[i]+",");
            }
            Console.Write("]");
        }

        // Esse método é referente à questão 2.1 -> Média dos elementos
        static double questaoDoisPontoUm(double[] itens,int indice, int tamanho)
        {

            if(indice > 0)
            {
                double med = itens[indice - 1] / tamanho + questaoDoisPontoUm(itens, indice - 1, tamanho);

                //verificar números maiores que a média
                if(indice == tamanho - 1)
                {
                    int qtdMaiorQueAMedia = 0;

                    for(int i = 0; i < tamanho; i++)
                    {
                        if(itens[i] > med)
                        {
                            qtdMaiorQueAMedia++;
                        }
                    }
                    Console.Write("Questão 2, ITEM 1: Número de Elementos Maiores que a Média: " + qtdMaiorQueAMedia);
                }

                return med;
            }
            return 0;
            
        }
        
        // Esse método é referente à questão 2.2 -> retornar lista com elementos de trás para frente
        static string[] questaoDoisPontoDois(string[] itens,int indice,int tamanho)
        {
            if(indice - 1 > tamanho / 2)
            {
                //Efetuar as trocas de posição para todos os itens com base no meio da lista              
                string valAtual = itens[indice-1];
                int destino = tamanho - (indice-1) - 1;
                itens[indice-1] = itens[destino];
                itens[destino] = valAtual;

                return questaoDoisPontoDois(itens, indice-1, tamanho);
            }
            
                return itens;
         
            
        }
    }
}
