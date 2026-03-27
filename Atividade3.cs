using System;

/*
└── IniciarJogo()
       ├── Jogadores()
       └── IniciarRodadas(1)   ← RECURSÃO
              ├── ExecutarRodada()
              ├── MostrarPlacar()
              └── IniciarRodadas(rodada + 1)
       
Final:
 └── Mostrar vencedor
*/

public class Jogadores
{
    public string nome;
    public int pontuacao;
}

