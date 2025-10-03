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
            xadrez.ConfigSimbolos.UsarSimbolos = option == "s";

            string rei = xadrez.ConfigSimbolos.UsarSimbolos ? "♔" : "K";
            string rainha = xadrez.ConfigSimbolos.UsarSimbolos ? "♕" : "Q";
            string torre = xadrez.ConfigSimbolos.UsarSimbolos ? "♖" : "R";
            string bispo = xadrez.ConfigSimbolos.UsarSimbolos ? "♗" : "B";
            string cavalo = xadrez.ConfigSimbolos.UsarSimbolos ? "♘" : "N";
            string peao = xadrez.ConfigSimbolos.UsarSimbolos ? "♙" : "P";

            Console.WriteLine($"Exemplo: {rei} {rainha} {torre} {bispo} {cavalo} {peao}");

            Console.WriteLine();

            Tabuleiro tab = new Tabuleiro (8,8);

            Tela.imprimirTabuleiro(tab);

            Console.ReadLine();
        }
    }
}