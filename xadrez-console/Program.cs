using tabuleiro;
using xadrez;

namespace xadrez_console
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Tabuleiro tab = new Tabuleiro(8, 8);

                tab.colocarPecas(new Torre(tab, Cor.Preta), new Posicao(0, 0));
                tab.colocarPecas(new Rei(tab, Cor.Branca), new Posicao(7, 0));
                tab.colocarPecas(new Torre(tab, Cor.Branca), new Posicao(2, 7));

                Tela.imprimirTabuleiro(tab);
            }
            catch (TabuleiroException e) 
            {
                Console.WriteLine(e.Message);
            }

            Console.ReadLine();
        }
    }
}
