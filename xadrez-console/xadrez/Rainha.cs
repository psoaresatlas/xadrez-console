using tabuleiro;

namespace xadrez
{
    class Rainha : Peca
    {
        public Rainha(Tabuleiro tab, Cor cor)
            : base(tab, cor)
        {

        }
        public override string ToString()
        {
            if (ConfigSimbolos.UsarSimbolos)
            {
                return "♕";
            }
            else
            {
                return "Q";
            }
        }

    }
}
