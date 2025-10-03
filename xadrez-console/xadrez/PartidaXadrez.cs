using System;
using tabuleiro;

namespace xadrez
{
    internal class PartidaXadrez
    {
        public Tabuleiro tab {  get; private set; }
        private int turno;
        private Cor jogadorAtual;
        public bool terminada {  get; private set; }

        public PartidaXadrez()
        {
            tab = new Tabuleiro(8, 8);
            turno = 1;
            jogadorAtual = Cor.Branca;
            terminada = false;
            colocarPecas();
        }

        public void executaMovimento(Posicao origem, Posicao destino)
        {
            Peca p = tab.retirarPeca(origem);
            p.incrementarQtdeMovimentos();
            Peca pecaCapturada = tab.retirarPeca(destino);
            tab.colocarPeca(p, destino);
        }

        private void colocarPecas()
        {
            tab.colocarPeca(new Torre(tab, Cor.Branca), new PosicaoXadrez('a', 1).conversorPosicao());
            tab.colocarPeca(new Torre(tab, Cor.Branca), new PosicaoXadrez('h', 1).conversorPosicao());
            tab.colocarPeca(new Cavalo(tab, Cor.Branca), new PosicaoXadrez('b', 1).conversorPosicao());
            tab.colocarPeca(new Cavalo(tab, Cor.Branca), new PosicaoXadrez('g', 1).conversorPosicao());
            tab.colocarPeca(new Bispo(tab, Cor.Branca), new PosicaoXadrez('c', 1).conversorPosicao());
            tab.colocarPeca(new Bispo(tab, Cor.Branca), new PosicaoXadrez('f', 1).conversorPosicao());
            tab.colocarPeca(new Rainha(tab, Cor.Branca), new PosicaoXadrez('d', 1).conversorPosicao());
            tab.colocarPeca(new Rei(tab, Cor.Branca), new PosicaoXadrez('e', 1).conversorPosicao());
            tab.colocarPeca(new Peao(tab, Cor.Branca), new PosicaoXadrez('a', 2).conversorPosicao());
            tab.colocarPeca(new Peao(tab, Cor.Branca), new PosicaoXadrez('b', 2).conversorPosicao());
            tab.colocarPeca(new Peao(tab, Cor.Branca), new PosicaoXadrez('c', 2).conversorPosicao());
            tab.colocarPeca(new Peao(tab, Cor.Branca), new PosicaoXadrez('d', 2).conversorPosicao());
            tab.colocarPeca(new Peao(tab, Cor.Branca), new PosicaoXadrez('e', 2).conversorPosicao());
            tab.colocarPeca(new Peao(tab, Cor.Branca), new PosicaoXadrez('f', 2).conversorPosicao());
            tab.colocarPeca(new Peao(tab, Cor.Branca), new PosicaoXadrez('g', 2).conversorPosicao());
            tab.colocarPeca(new Peao(tab, Cor.Branca), new PosicaoXadrez('h', 2).conversorPosicao());

            tab.colocarPeca(new Torre(tab, Cor.Preta), new PosicaoXadrez('a', 8).conversorPosicao());
            tab.colocarPeca(new Torre(tab, Cor.Preta), new PosicaoXadrez('h', 8).conversorPosicao());
            tab.colocarPeca(new Cavalo(tab, Cor.Preta), new PosicaoXadrez('b', 8).conversorPosicao());
            tab.colocarPeca(new Cavalo(tab, Cor.Preta), new PosicaoXadrez('g', 8).conversorPosicao());
            tab.colocarPeca(new Bispo(tab, Cor.Preta), new PosicaoXadrez('c', 8).conversorPosicao());
            tab.colocarPeca(new Bispo(tab, Cor.Preta), new PosicaoXadrez('f', 8).conversorPosicao());
            tab.colocarPeca(new Rainha(tab, Cor.Preta), new PosicaoXadrez('d', 8).conversorPosicao());
            tab.colocarPeca(new Rei(tab, Cor.Preta), new PosicaoXadrez('e', 8).conversorPosicao());
            tab.colocarPeca(new Peao(tab, Cor.Preta), new PosicaoXadrez('a', 7).conversorPosicao());
            tab.colocarPeca(new Peao(tab, Cor.Preta), new PosicaoXadrez('b', 7).conversorPosicao());
            tab.colocarPeca(new Peao(tab, Cor.Preta), new PosicaoXadrez('c', 7).conversorPosicao());
            tab.colocarPeca(new Peao(tab, Cor.Preta), new PosicaoXadrez('d', 7).conversorPosicao());
            tab.colocarPeca(new Peao(tab, Cor.Preta), new PosicaoXadrez('e', 7).conversorPosicao());
            tab.colocarPeca(new Peao(tab, Cor.Preta), new PosicaoXadrez('f', 7).conversorPosicao());
            tab.colocarPeca(new Peao(tab, Cor.Preta), new PosicaoXadrez('g', 7).conversorPosicao());
            tab.colocarPeca(new Peao(tab, Cor.Preta), new PosicaoXadrez('h', 7).conversorPosicao());


        }
    }
}
