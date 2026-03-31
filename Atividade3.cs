/*using System;

class Program{

    static void Main(){
        Console.WriteLine("BEM-VINDO! - JOGAR DADOS");

        // Instaciando a classe e criando o jogador 1
        Jogadores jogador1 = new Jogadores();
        Console.WriteLine("Digite o nome do Jogador 1:");
        jogador1.Nome = Console.ReadLine()!;

        // Instanciando a classe e criando o jogador 2
        Jogadores jogador2 = new Jogadores();
        Console.WriteLine("Digite o nome do Jogador 2:");
        jogador2.Nome = Console.ReadLine()!;

        // Chamada do método recursivo 
        JogarRodadas(1, jogador1, jogador2);
        // Chama o método que verifica o vencedor
        VerificaVencedor(jogador1, jogador2);

    }

    // Classe Jogadores
    public class Jogadores
    {
        public string Nome;
        public int Pontuacao;
    }

    // Método com recursão para contabilizar as rodadas
    static void JogarRodadas(int rodada, Jogadores jogador1, Jogadores jogador2)
    {
        // Condição de parada
        if (rodada > 3)
        {
            Console.WriteLine("\nFim do jogo!");
            return;
        }

        Console.WriteLine($"\n--- Rodada {rodada} ---");
        
        // Em cada rodada, chama a função JogarDados
        JogarDados(jogador1, jogador2);

        JogarRodadas(rodada + 1, jogador1, jogador2);
    }

    static void JogarDados(Jogadores jogador1, Jogadores jogador2)
    {
        // Gera números de 1 a 6
        Random random = new Random();
        int valor1 = random.Next(1, 7);
        int valor2 = random.Next(1, 7);

        // Exibe o número tirado por cada jogador
        Console.WriteLine(jogador1.Nome+" tirou o número "+valor1);
        Console.WriteLine(jogador2.Nome+" tirou o número "+valor2);

        // Exibe o vencedor da rodada
        if(valor1 > valor2){
            Console.WriteLine(jogador1.Nome+" venceu essa rodada."); // colocar depois o número da rodada
        }else if(valor2 > valor1){
            Console.WriteLine(jogador2.Nome+" venceu essa rodada."); // colocar depois o número da rodada
        }

        // Se for empate, exibe uma mensagem, se não for contabiliza os pontos
        if(valor1 == valor2)
        {
            Console.WriteLine("Empate.");
        }else
        {
            jogador1.Pontuacao += valor1;
            jogador2.Pontuacao += valor2;
        }
    }

    static void VerificaVencedor(Jogadores jogador1, Jogadores jogador2)
    {
        // Exibe a pontuação de cada jogador
        Console.WriteLine(jogador1.Nome+" - Pontuação: "+jogador1.Pontuacao);
        Console.WriteLine(jogador2.Nome+" - Pontuação: "+jogador2.Pontuacao);

        // Verifica a diferença das pontuações, e exibe o vencedor
        if(jogador1.Pontuacao > jogador2.Pontuacao)
        {
            Console.WriteLine(jogador1.Nome+" venceu o jogo.");
        }else if(jogador1.Pontuacao == jogador2.Pontuacao)
        {
            Console.WriteLine("Empate");
        }else
        {
            Console.WriteLine(jogador2.Nome+" venceu o jogo.");
        }
    }

}
*/