using System;
using tabuleiro;
using xadrez;

namespace xadrez_console
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.WriteLine("Simbolos gráficos: ♔, ♕, ♖, ♗, ♘, ♙\n" +
                "Letras: K, Q, R, B, N, P");
            Console.WriteLine();
            Console.WriteLine("Usar símbolos gráficos de xadrez? (s/n)");
            string option = Console.ReadLine().ToLower();
            xadrez.ConfigSimbolos.UsarSimbolos = option == "s";

            string rei = xadrez.ConfigSimbolos.UsarSimbolos ? "♔" : "K";
            string rainha = xadrez.ConfigSimbolos.UsarSimbolos ? "♕" : "Q";
            string torre = xadrez.ConfigSimbolos.UsarSimbolos ? "♖" : "R";
            string bispo = xadrez.ConfigSimbolos.UsarSimbolos ? "♗" : "B";
            string cavalo = xadrez.ConfigSimbolos.UsarSimbolos ? "♘" : "N";
            string peao = xadrez.ConfigSimbolos.UsarSimbolos ? "♙" : "P";

            Console.WriteLine($"Exemplo: {rei} {rainha} {torre} {bispo} {cavalo} {peao}");

            Console.WriteLine("Pressione ENTER para iniciar o jogo...");
            Console.ReadLine();

            Console.WriteLine();


            try
            {
                PartidaXadrez partida = new PartidaXadrez();

                while (!partida.terminada)
                {
                    try
                    {
                        Console.Clear();
                        Tela.imprimirTabuleiro(partida.tab);
                        Console.WriteLine();

                        Console.WriteLine("Turno: " + partida.turno);
                        Console.WriteLine("Aguardando jogada: " + partida.jogadorAtual);
                        Console.WriteLine();

                        Console.Write("Origem: ");
                        Posicao origem = Tela.lerPosicaoXadrez().conversorPosicao();
                        partida.validarPosicaoOrigem(origem);

                        bool[,] posicoesPossiveis = partida.tab.peca(origem).movimentosPossiveis();

                        Console.Clear();
                        Tela.imprimirTabuleiro(partida.tab, posicoesPossiveis);

                        Console.WriteLine();
                        Console.Write("Destino: ");
                        Posicao destino = Tela.lerPosicaoXadrez().conversorPosicao();

                        partida.validarPosicaoDestino(origem, destino);

                        partida.realizaJogada(origem, destino);
                    }
                    catch (TabuleiroException e)
                    {
                        Console.WriteLine();
                        Console.WriteLine("Erro: " + e.Message);
                        Console.WriteLine("Pressione ENTER para continuar...");
                        Console.ReadLine();

                    }
                    catch (FormatException e)
                    {
                        Console.WriteLine();
                        Console.WriteLine("Entrada inválida: " + e.Message);
                        Console.WriteLine("Pressione ENTER para continuar...");
                        Console.ReadLine();
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine();
                        Console.WriteLine("Erro inesperado: " + e.Message);
                        Console.WriteLine("Pressione ENTER para continuar...");
                        Console.ReadLine();
                    }
                }

                Console.Clear();
                Tela.imprimirTabuleiro(partida.tab);
                Console.WriteLine();
                Console.WriteLine("XEQUE-MATE!");
                Console.WriteLine("Vencedor: " + partida.jogadorAtual);
            }
            catch (Exception e)
            {
                Console.WriteLine("Erro fatal: " + e.Message);
            }
        }
    }
}
