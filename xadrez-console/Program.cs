using System;
using tabuleiro;

namespace xadrez_console
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8; //Quero dar a opção do usuário usar os símbolos ao invés das letras, o jogo fica mais legal


            Console.WriteLine("Simbolos gráficos: ♔, ♕, ♖, ♗, ♘, ♙\n" +
                "Letras: K, Q, R, B, N, P");
            Console.WriteLine();
            Console.WriteLine("Usar símbolos gráficos de xadrez? (s/n)");
            string option = Console.ReadLine().ToLower();
            xadrez.Config.UsarSimbolos = option == "s";

            string rei = xadrez.Config.UsarSimbolos ? "♔" : "K";
            string rainha = xadrez.Config.UsarSimbolos ? "♕" : "Q";
            string torre = xadrez.Config.UsarSimbolos ? "♖" : "R";
            string bispo = xadrez.Config.UsarSimbolos ? "♗" : "B";
            string cavalo = xadrez.Config.UsarSimbolos ? "♘" : "N";
            string peao = xadrez.Config.UsarSimbolos ? "♙" : "P";

            Console.WriteLine($"Exemplo: {rei} {rainha} {torre} {bispo} {cavalo} {peao}");

            Console.WriteLine();

            Tabuleiro tab = new Tabuleiro (8,8);

            Tela.imprimirTabuleiro(tab);

            Console.ReadLine();
        }
    }
}