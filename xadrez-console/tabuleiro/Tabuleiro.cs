namespace tabuleiro {
    internal class Tabuleiro {

        public int linhas { set; get; }
        public int colunas { set; get; }
        public Peca[,] pecas;

        public Tabuleiro (int linhas, int colunas) {
            this.linhas = linhas;
            this.colunas = colunas;
            pecas = new Peca[linhas, colunas];
        }
        public Peca peca(int linhas, int colunas)
        {
            return pecas[linhas, colunas];
        }
    }
}
