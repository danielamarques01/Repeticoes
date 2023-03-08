using System;
using System.Collections.Generic;
using System.Globalization;
using System.Runtime.Intrinsics.X86;

namespace EstruturaDeRepeticao
{
    class Program
    {
        static void Main(string[] args)
        {
            /*A diretora de uma escola precisa de um programa C# que exiba uma mensagem de boas vindas para os 10 alunos novos, utilizando a estrutura Foreach 
             exiba a mesma mensagem para todos os alunos novos.
 
             
            string[] nomes = { "João", "Julia", "Gabriel", "Pedro", "Camila", "Daniela", "Agata", "Celilia", "Helena", "Henrique" };
            foreach (string nome in nomes)  // para cada "nome" no array "nomes, repita o bloco de códigos
            {
                Console.WriteLine("Bem-vindo alunos(as) " + nome + "!");
            }*/

            //-------------------------------------------------------------------------------------------------------------------------------------------------------------------

            /*Crie um programa C# usando as estruturas de repetição que contabilize a velocidade de um carro de fórmula 1, sem ultrapassar o limite de 200 Km / h 
            permitido na pista, exiba uma mensagem no final informando que chegou no limite.

            int contador = 0;
            while (contador < 200) 
            {
                Console.WriteLine("O carro está a " + contador + "Km/h");
                contador++;

                Console.WriteLine("O CARRO ATINGIU A VELOCIDADE PERMITIDA NA PISTA");

            }*/

            //-------------------------------------------------------------------------------------------------------------------------------------------------------------------

            /*Crie um programa C# que exiba para os clientes de um mercado que está abertosob a condição do seu horário de funcionamento das 7h às 17h após esse 
            horário exibir uma mensagem de que se encontra fechado e indicando o horário de funcionamento deste estabelecimento.

            int horario = 7;
            while (horario >= 7 && horario <= 17)
            {
                Console.WriteLine("São: " + horario + " Horas" + " | O mercado está aberto");

                horario++;
            }
            Console.WriteLine("O MERCADO ESTÁ FECHADO! ");
            Console.WriteLine("HORÁRIO DE FUNCIONAMENTO: 07:00 ÀS 17:00"); */

            //-------------------------------------------------------------------------------------------------------------------------------------------------------------------

            /*Crie um programa C# que exiba um cardápio de uma pizzaria contando 10 sabores de pizza, exiba na tela repetindo a frase: “ Temos o sabor: ” 
            “Aproveite a refeição” nos 10 sabores

            string[] pizzas = { "Frango", "Frango c/ Catupiry", "Calabresa", "Margherita", "Portuguesa", "Quatro Queijos", "Cinco Queijos", "Peperone", "Brocolis", "Muçarela" };

            Console.WriteLine("Temos os sabores: ");

            foreach (string pizza in pizzas) 
            {
                
                Console.WriteLine(pizza);
            }
            Console.WriteLine("Aproveite a refeição!"); */

            //-------------------------------------------------------------------------------------------------------------------------------------------------------------------

            /*Utilizando as estruturas de repetição, crie um programa C# que Realize uma Contagem regressiva de 1000 a 1 para que um foguete seja lançado ao espaço.

            for (int contador = 1000; contador > 0; contador--)
            {
                Console.WriteLine("Contando: " + contador);
            }
            Console.WriteLine("O FOGUETE FOI PARA O ESPAÇO! ");*/
        }
    }
}