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

                Tabuleiro tab = new Tabuleiro(8, 8);

                tab.colocarPeca(new Torre(tab, Cor.Branca), new Posicao(7, 0));
                tab.colocarPeca(new Torre(tab, Cor.Branca), new Posicao(7, 7));
                tab.colocarPeca(new Cavalo(tab, Cor.Branca), new Posicao(7, 1));
                tab.colocarPeca(new Cavalo(tab, Cor.Branca), new Posicao(7, 6));
                tab.colocarPeca(new Bispo(tab, Cor.Branca), new Posicao(7, 2));
                tab.colocarPeca(new Bispo(tab, Cor.Branca), new Posicao(7, 5));
                tab.colocarPeca(new Rainha(tab, Cor.Branca), new Posicao(7, 3));
                tab.colocarPeca(new Rei(tab, Cor.Branca), new Posicao(7, 4));
                tab.colocarPeca(new Peao(tab, Cor.Branca), new Posicao(6, 0));
                tab.colocarPeca(new Peao(tab, Cor.Branca), new Posicao(6, 1));
                tab.colocarPeca(new Peao(tab, Cor.Branca), new Posicao(6, 2));
                tab.colocarPeca(new Peao(tab, Cor.Branca), new Posicao(6, 3));
                tab.colocarPeca(new Peao(tab, Cor.Branca), new Posicao(6, 4));
                tab.colocarPeca(new Peao(tab, Cor.Branca), new Posicao(6, 5));
                tab.colocarPeca(new Peao(tab, Cor.Branca), new Posicao(6, 6));
                tab.colocarPeca(new Peao(tab, Cor.Branca), new Posicao(6, 7));

                tab.colocarPeca(new Torre(tab, Cor.Preta), new Posicao(0, 0));
                tab.colocarPeca(new Torre(tab, Cor.Preta), new Posicao(0, 7));
                tab.colocarPeca(new Cavalo(tab, Cor.Preta), new Posicao(0, 1));
                tab.colocarPeca(new Cavalo(tab, Cor.Preta), new Posicao(0, 6));
                tab.colocarPeca(new Bispo(tab, Cor.Preta), new Posicao(0, 2));
                tab.colocarPeca(new Bispo(tab, Cor.Preta), new Posicao(0, 5));
                tab.colocarPeca(new Rainha(tab, Cor.Preta), new Posicao(0, 3));
                tab.colocarPeca(new Rei(tab, Cor.Preta), new Posicao(0, 4));
                tab.colocarPeca(new Peao(tab, Cor.Preta), new Posicao(1, 0));
                tab.colocarPeca(new Peao(tab, Cor.Preta), new Posicao(1, 1));
                tab.colocarPeca(new Peao(tab, Cor.Preta), new Posicao(1, 2));
                tab.colocarPeca(new Peao(tab, Cor.Preta), new Posicao(1, 3));
                tab.colocarPeca(new Peao(tab, Cor.Preta), new Posicao(1, 4));
                tab.colocarPeca(new Peao(tab, Cor.Preta), new Posicao(1, 5));
                tab.colocarPeca(new Peao(tab, Cor.Preta), new Posicao(1, 6));
                tab.colocarPeca(new Peao(tab, Cor.Preta), new Posicao(1, 7));

                
                Tela.imprimirTabuleiro(tab);
            }
            catch (TabuleiroException e)
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadLine();
        }
    }
}