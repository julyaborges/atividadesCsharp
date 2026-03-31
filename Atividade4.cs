using System;
using System.Globalization;

class Program
{
    static void Main()
    {
        bool exibirMenu = true;
        int opcao1 = 0;
        int opcao2 = 0;
        
        while(exibirMenu)
        {      
            Console.WriteLine("BEM-VINDO - CONVERSÃO DE DATAS");
            Console.WriteLine("Qual formato de data você deseja visualizar?");
            Console.WriteLine("1 - Configuração do Sistema: 08/01/2021 20:48:13");
            Console.WriteLine("2 - Formato simples: 08-01-21");
            Console.WriteLine("3 - Formato longo: sexta-feira, 8 de janeiro de 2021");
            Console.WriteLine("4 - Formato longo personalizado 08-01-2021 08:48:13");
            Console.WriteLine("5 - Formato RFC1123 pattern Fri, 08 Jan 2021 20:48:13 GMT");
            opcao1 = int.Parse(Console.ReadLine());

            if(opcao1 < 1 || opcao1 > 5)
            {
                Console.WriteLine("Opção inválida.");
            }
            else
            {
                exibirMenu = false;
            }
        }
    
        Console.WriteLine("Escolha uma dessas opções:");
        Console.WriteLine("1 - ENIAC");
        Console.WriteLine("2 - RFC1");
        Console.WriteLine("3 - Alan Turing");
        opcao2 = int.Parse(Console.ReadLine());

        DataConfiguracao obj = new DataConfiguracao();
        obj.ConfigurarFormato(opcao1, opcao2);
        obj.AplicarFormato();
        obj.ExibirCabecalho();
    }

    class DataConfiguracao
    {

        private int Formato;
        private int OpcaoData;
        private DateTime DataSelecionada;
        private string DataFormatada;

        public void ConfigurarFormato(int opcao1, int opcao2)
        {
            Formato = opcao1; 
            OpcaoData = opcao2;   

            if(OpcaoData == 1)
            {
                DataSelecionada = new DateTime(1946, 8, 15);
            }else if(OpcaoData == 2){
                DataSelecionada = new DateTime(1969, 4, 17);
            }else{
                DataSelecionada = new DateTime(1912, 6, 23);
            }
        }
    
        public void AplicarFormato()
        {
            if(Formato == 1){
                DataFormatada = DataSelecionada.ToString();
            }else if(Formato == 2){
                DataFormatada = DataSelecionada.ToString("dd-MM-yy");
            }else if(Formato == 3){
                DataFormatada = DataSelecionada.ToString(
                    "dddd, d 'de' MMMM 'de' yyyy",
                    new CultureInfo("pt-BR")
                );
            }else if(Formato == 4){
                DataFormatada = DataSelecionada.ToString("dd-MM-yyyy HH:mm:ss");
            }else{
                DataFormatada = DataSelecionada.ToUniversalTime().ToString("R");
            }
        }

        public void ExibirCabecalho()
        {
            if(OpcaoData == 1){
                Console.WriteLine(DataFormatada);
                Console.WriteLine("No dia 15 de agosto de 1946 os norte-americanos John Eckert e John Mauchly apresentaram o ENIAC, o primeiro equipamento eletrônico chamado de computador no mundo.");
            }else if(OpcaoData == 2){
                Console.WriteLine(DataFormatada);
                Console.WriteLine("Em 17 de abril de 1969 foi feita a publicação da RFC1, por esse motivo considera-se esse o dia da internet até hoje.");
            }else{
                Console.WriteLine(DataFormatada);
                Console.WriteLine("Nascimento de Alan Turing, matemático e criptoanalista britânico considerado o pai da informática, essencial na criação de máquinas que deram origem aos PCs.");
            }
        }
    }
}