using tabuleiro;

namespace xadrez_console.tabuleiro
{
    internal class Peca
    {

        public Posicao posicao {  get; set; }
        public Cor cor { get; protected set; }
        public int qtdMovimentos { get; set; }
        public Tabuleiro tab {  get; set; }

        public Peca(Posicao posicao, Cor cor, Tabuleiro tab)
        {
            this.posicao = posicao;
            this.cor = cor;
            this.qtdMovimentos = 0;
            this.tab = tab;
        }
    }
}
