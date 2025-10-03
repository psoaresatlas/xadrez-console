using tabuleiro;

namespace xadrez
{
    class Cavalo : Peca
    {
        public Cavalo(Tabuleiro tab, Cor cor)
            : base(tab, cor)
        {

        }
        public override string ToString()
        {
            if (ConfigSimbolos.UsarSimbolos)
            {
                return "♘";
            }
            else
            {
                return "N";
            }
        }

    }
}