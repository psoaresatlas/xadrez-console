using tabuleiro;

namespace tabuleiro
{
    class Peca
    {

        public Posicao posicao {  get; set; }
        public Cor cor { get; protected set; }
        public int qtdMovimentos { get; set; }
        public Tabuleiro tab {  get; set; }

        public Peca(Tabuleiro tab, Cor cor)
        {
            this.posicao = null;
            this.cor = cor;
            this.qtdMovimentos = 0;
            this.tab = tab;
        }
    }
}
