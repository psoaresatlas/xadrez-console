using tabuleiro;

namespace xadrez
{
    class Rei : Peca
    {
        public Rei(Tabuleiro tab, Cor cor)
            :base(tab, cor)
        {

        }
         public override string ToString()
        {
            if (Config.UsarSimbolos)
            {
                return "♔"; // ou ♚ se quiser diferenciar branco e preto
            }
            else
            {
                return "K";
            }
        }

    }
}
