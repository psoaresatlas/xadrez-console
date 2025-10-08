using tabuleiro;

namespace tabuleiro
{
    abstract class Peca
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

        public void incrementarQtdeMovimentos()
        {
            qtdMovimentos++;
        }

        public bool possibilidadeMovimento()
        {
            bool[,] mat = movimentosPossiveis();
            for (int i = 0; i< tab.linhas; i++)
            {
                for (int j = 0; j < tab.colunas; j++)
                {
                    if (mat[i, j])
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        public abstract bool[,] movimentosPossiveis();
    }
}
