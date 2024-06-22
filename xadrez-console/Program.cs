using tabuleiro;
using xadrez;

namespace xadrez_console
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Tabuleiro tab = new Tabuleiro(8, 8);

            tab.colocarPecas(new Torre(tab, Cor.Preta), new Posicao(0, 0));
            tab.colocarPecas(new Rei(tab, Cor.Branca), new Posicao(7, 0));

            Tela.imprimirTabuleiro(tab);

            Console.ReadLine();
        }
    }
}
