using System;
using tabuleiro;
using xadrez;

namespace xadrez_console
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.OutputEncoding = System.Text.Encoding.UTF8; //Quero dar a opção do usuário usar os símbolos ao invés das letras, o jogo fica mais legal


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

                Console.WriteLine();

                PartidaXadrez partida = new PartidaXadrez();

                while (!partida.terminada)
                {
                    Console.Clear();
                    Tela.imprimirTabuleiro(partida.tab);

                    Console.WriteLine();    

                    Console.Write("Origem:");
                    Posicao origem = Tela.lerPosicaoXadrez().conversorPosicao();

                    bool[,] posicoesPossiveis = partida.tab.peca(origem).movimentosPossiveis();

                    Console.Clear();
                    Tela.imprimirTabuleiro(partida.tab, posicoesPossiveis);

                    Console.Write("Destino:");
                    Posicao destino = Tela.lerPosicaoXadrez().conversorPosicao();

                    partida.executaMovimento(origem, destino);
                }

                
                Tela.imprimirTabuleiro(partida.tab);
            }
            catch (TabuleiroException e)
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadLine();
        }
    }
}