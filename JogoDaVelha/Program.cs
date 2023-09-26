using System.Globalization;

class JogoDaVelha
{
    static char[,] tabuleiro = new char[3, 3];
    static bool jogadorX = true;
    static int jogadas = 0;

    static void Main(string[] args)
    {
        InicializarTabuleiro();
        MostrarTabuleiro();

        while (true)
        {
            RealizarJogada();
            MostrarTabuleiro();
            
            if (VerificarFimDeJogo())
                break;
        }
    }

    static void InicializarTabuleiro()
    {
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                tabuleiro[i, j] = ' ';
            }
        }
    }

    static void MostrarTabuleiro()
    {
        Console.Clear();
        Console.WriteLine(" 0 1 2");
        for (int i = 0; i < 3; i++)
        {
            Console.Write(i + " ");
            for (int j = 0; j < 3; j++)
            {
                Console.Write(tabuleiro[i, j] + " ");
            }
            Console.WriteLine();
        }
    }

    static void RealizarJogada()
    {
        int linha, coluna;
        do
        {
            Console.WriteLine("Jogador " + (jogadorX ? "X" : "O") + ", informe a linha (0, 1 ou 2) e a coluna (0, 1 ou 2) da sua jogada (ex: 0 0): ");
            string[] entrada = Console.ReadLine().Split();
            linha = int.Parse(entrada[0]);
            coluna = int.Parse(entrada[1]);
        } while (linha < 0 || linha > 2 || coluna < 0 || coluna > 2 || tabuleiro[linha, coluna] != ' ');

        tabuleiro[linha, coluna] = jogadorX ? 'X' : 'O';
        jogadorX = !jogadorX;
        jogadas++;
    }

    static bool VerificarFimDeJogo()
    {
        if (jogadas >= 5) // O jogo pode acabar depois de 5 jogadas
        {
            for (int i = 0; i < 3; i++)
            {
                // Verificar linhas e colunas
                if (tabuleiro[i, 0] != ' ' && tabuleiro[i, 0] == tabuleiro[i, 1] && tabuleiro[i, 1] == tabuleiro[i, 2])
                {
                    Console.WriteLine("Jogador " + (tabuleiro[i, 0] == 'X' ? "X" : "O") + " venceu!");
                    return true;
                }
                if (tabuleiro[0, i] != ' ' && tabuleiro[0, i] == tabuleiro[1, i] && tabuleiro[1, i] == tabuleiro[2, i])
                {
                    Console.WriteLine("Jogador " + (tabuleiro[0, i] == 'X' ? "X" : "O") + " venceu!");
                    return true;
                }
            }

            // Verificar diagonais
            if (tabuleiro[0, 0] != ' ' && tabuleiro[0, 0] == tabuleiro[1, 1] && tabuleiro[1, 1] == tabuleiro[2, 2])
            {
                Console.WriteLine("Jogador " + (tabuleiro[0, 0] == 'X' ? "X" : "O") + " venceu!");
                return true;
            }
            if (tabuleiro[0, 2] != ' ' && tabuleiro[0, 2] == tabuleiro[1, 1] && tabuleiro[1, 1] == tabuleiro[2, 0])
            {
                Console.WriteLine("Jogador " + (tabuleiro[0, 2] == 'X' ? "X" : "O") + " venceu!");
                return true;
            }
        }

        if (jogadas == 9)
        {
            Console.WriteLine("O jogo terminou em empate!");
            return true;
        }

        return false;
    }
}