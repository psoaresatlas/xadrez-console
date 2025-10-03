using tabuleiro;

namespace xadrez
{
    class Peao : Peca
    {
        public Peao(Tabuleiro tab, Cor cor)
            : base(tab, cor)
        {

        }
        public override string ToString()
        {
            if (ConfigSimbolos.UsarSimbolos)
            {
                return "♙";
            }
            else
            {
                return "P";
            }
        }

    }
}
