using tabuleiro;

namespace xadrez
{
    class Torre : Peca
    {
        public Torre(Tabuleiro tab, Cor cor)
            : base(tab, cor)
        {

        }
        public override string ToString()
        {
            if (ConfigSimbolos.UsarSimbolos)
            {
                return "♖";
            }
            else
            {
                return "R";
            }
        }

    }
}
