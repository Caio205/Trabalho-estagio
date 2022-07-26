﻿using System;

namespace Teste_trabalho
{
    class Program
    {
        public static void Main(string[] args)
        {
            string opc;
            Manipulacao mn = new Manipulacao();
            Console.WriteLine("Seja bem vindo");
            do
            {
                Console.Clear();
                Console.ResetColor();
                Console.WriteLine("Escolha uma opção:");
                Console.WriteLine("+----------------------+");
                Console.WriteLine("| 1-Incluir Produtos   |");
                Console.WriteLine("| 2-Alterar Produtos   |");
                Console.WriteLine("| 3-Remover Produtos   |");
                Console.WriteLine("| 4-Listar Produtos    |");
                Console.WriteLine("| 5-Sair               |");
                Console.WriteLine("+----------------------+");
                Console.Write("\nR:");
                opc = Console.ReadLine();
                
                Console.Clear();

                if (opc == "1")
                {
                    Console.Write("Digite o Nome do Produto:");
                    string nomep = Console.ReadLine();
                    Console.Write("Digite o Valor do Produto:");
                    string valorp = Console.ReadLine().Replace(",", ".");
                    Console.Write("Digite a quantidade do Produto:");
                    int qtdp = Convert.ToInt32(Console.ReadLine());
                    mn.Inclusão(nomep, valorp, qtdp);
                }

                if (opc == "2")
                {
                    Console.Write("Digite o nome do Produto que deseja alterar:");
                    string nomep = Console.ReadLine();
                    Console.Write("Digite o novo Valor do Produto:");
                    string valorp = Console.ReadLine().Replace(",", ".");
                    Console.Write("Digite a nova quantidade do Produto:");
                    int qtdp = Convert.ToInt32(Console.ReadLine());
                    mn.Alteração(nomep, valorp, qtdp);
                }

                if (opc == "3")
                {
                    Console.Write("Digite o nome do Produto que deseja remover:");
                    string nomep = Console.ReadLine();
                    mn.Deletar(nomep);
                }

                if (opc == "4")
                {
                    mn.Consulta();
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("\nAperte qualquer tecla para voltar");
                    Console.ReadKey();
                }
            } while (opc != "5");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Obrigado por usar este programa! :)");
        }
    }
}