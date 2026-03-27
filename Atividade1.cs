/*using System;

int resultado = 0;
bool continuar = true;

while(continuar)
{
    // Menu da Calculadora 
    Console.WriteLine("MENU - CALCULADORA");
    Console.WriteLine("1 - Somar");
    Console.WriteLine("2 - Subtrair");
    Console.WriteLine("3 - Multiplicar");
    Console.WriteLine("4 - Dividir");
    Console.WriteLine("0 - Sair");

    // Selecionar a opção
    Console.Write("Digite a opção: ");
    int opcao = int.Parse(Console.ReadLine());

    if(opcao != 0)
    {
        // Recebe o primeiro valor
        Console.Write("Digite o primeiro valor:");
        int valor1 = int.Parse(Console.ReadLine());
        // Recebe o segundo valor
        Console.Write("Digite o segundo valor:");
        int valor2 = int.Parse(Console.ReadLine());

        switch (opcao)
        {
        case 1:
            resultado = valor1 + valor2;
            break;
        case 2:
            resultado = valor1 - valor2;
            break;
        case 3:
            resultado = valor1 * valor2;
            break;
        case 4:
            if(valor2 == 0)
            {
                Console.WriteLine("Não é possível dividir por zero.");
                resultado = 0;
            } 
            else
            {
                resultado = valor1 / valor2;
            }
            break;
        default:
            Console.WriteLine("Opção inválida.");
            break;
        }

        Console.WriteLine("Resultado: "+resultado);
        Console.ReadLine();
    }
    else
    {
        continuar = false;
    }
}

Console.WriteLine("Fim do programa!");

*/