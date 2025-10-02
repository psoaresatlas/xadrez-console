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

            bool usarSimbolos = option == "s";

            string rei = usarSimbolos ? "♔" : "K";
            string rainha = usarSimbolos ? "♕" : "Q";
            string torre = usarSimbolos ? "♖" : "R";
            string bispo = usarSimbolos ? "♗" : "B";
            string cavalo = usarSimbolos ? "♘" : "N";
            string peao = usarSimbolos ? "♙" : "P";

            Console.WriteLine($"Exemplo: {rei} {rainha} {torre} {bispo} {cavalo} {peao}");

            Tabuleiro tab = new Tabuleiro (8,8);

        }
    }
}