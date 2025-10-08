using System;
using tabuleiro;

namespace xadrez
{
    internal class PartidaXadrez
    {
        public Tabuleiro tab { get; private set; }
        public int turno { get; private set; }
        public Cor jogadorAtual { get; private set; }
        public bool terminada { get; private set; }

        public PartidaXadrez()
        {
            tab = new Tabuleiro(8, 8);
            turno = 1;
            jogadorAtual = Cor.Branca;
            terminada = false;
            colocarPecas();
        }

        public Peca executaMovimento(Posicao origem, Posicao destino)
        {
            Peca p = tab.retirarPeca(origem);
            p.incrementarQtdeMovimentos();
            Peca pecaCapturada = tab.retirarPeca(destino);
            tab.colocarPeca(p, destino);
            return pecaCapturada;
        }

        public void desfazMovimento(Posicao origem, Posicao destino, Peca pecaCapturada)
        {
            Peca p = tab.retirarPeca(destino);
            p.qtdMovimentos--;
            if (pecaCapturada != null)
            {
                tab.colocarPeca(pecaCapturada, destino);
            }
            tab.colocarPeca(p, origem);
        }

        public void realizaJogada(Posicao origem, Posicao destino)
        {
            Peca pecaCapturada = executaMovimento(origem, destino);

            if (reiEmXeque(jogadorAtual))
            {
                desfazMovimento(origem, destino, pecaCapturada);
                throw new TabuleiroException("Você não pode se colocar em xeque!");
            }

            turno++;
            mudaJogador();

        }

        public void validarPosicaoOrigem(Posicao pos)
        {
            if (tab.peca(pos) == null)
            {
                throw new TabuleiroException("Não existe peça na posição de origem escolhida!");
            }
            if (jogadorAtual != tab.peca(pos).cor)
            {
                throw new TabuleiroException("A peça que você escolheu não é sua!");
            }
            if (!tab.peca(pos).possibilidadeMovimento())
            {
                throw new TabuleiroException("Não existe possibilidade de movimento para essa peça");
            }
        }

        public void validarPosicaoDestino(Posicao origem, Posicao destino)
        {
            if (!tab.peca(origem).movimentosPossiveis()[destino.linha, destino.coluna])
            {
                throw new TabuleiroException("Posição de destino inválida!");
            }
        }

        public bool reiEmXeque(Cor cor)
        {
            Posicao posRei = encontrarRei(cor);
            if (posRei == null)
            {
                throw new TabuleiroException("Não foi possível encontrar o rei da cor " + cor);
            }

            for (int i = 0; i < tab.linhas; i++)
            {
                for (int j = 0; j < tab.colunas; j++)
                {
                    Peca p = tab.peca(i, j);
                    if (p != null && p.cor != cor)
                    {
                        bool[,] mat = p.movimentosPossiveis();
                        if (mat[posRei.linha, posRei.coluna])
                        {
                            return true;
                        }
                    }
                }
            }
            return false;
        }

        private Posicao encontrarRei(Cor cor)
        {
            for (int i = 0; i < tab.linhas; i++)
            {
                for (int j = 0; j < tab.colunas; j++)
                {
                    Peca p = tab.peca(i, j);
                    if (p != null && p is Rei && p.cor == cor)
                    {
                        return new Posicao(i, j);
                    }
                }
            }
            return null;
        }

        private void mudaJogador()
        {
            if (jogadorAtual == Cor.Branca)
            {
                jogadorAtual = Cor.Preta;
            }
            else
            {
                jogadorAtual = Cor.Branca;
            }
        }

        private void colocarPecas()
        {
            tab.colocarPeca(new Torre(tab, Cor.Branca), new PosicaoXadrez('a', 1).conversorPosicao());
            tab.colocarPeca(new Torre(tab, Cor.Branca), new PosicaoXadrez('h', 1).conversorPosicao());
            tab.colocarPeca(new Rei(tab, Cor.Branca), new PosicaoXadrez('e', 1).conversorPosicao());

            tab.colocarPeca(new Torre(tab, Cor.Preta), new PosicaoXadrez('a', 8).conversorPosicao());
            tab.colocarPeca(new Torre(tab, Cor.Preta), new PosicaoXadrez('h', 8).conversorPosicao());
            tab.colocarPeca(new Rei(tab, Cor.Preta), new PosicaoXadrez('e', 8).conversorPosicao());
        }
    }
}
