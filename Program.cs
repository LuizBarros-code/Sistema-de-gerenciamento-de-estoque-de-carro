using Microsoft.Win32.SafeHandles;

List<Fabricante> fabricantes = new List<Fabricante>();

int opcao;

void Exibirmenu(){
    Console.Clear();
    Console.WriteLine("*******************************");
    Console.WriteLine("GERENCIADOR DE ESTOQUE DE CARRO");
    Console.WriteLine("*******************************");
    Console.WriteLine("1-Adicionar fabricante");
    Console.WriteLine("2-Adicionar carro");
    Console.WriteLine("3-Visualizar fabricante");
    Console.WriteLine("4-Visualizar carro");
    Console.WriteLine("0-Para sair do sistema");
    Console.WriteLine("*******************************");
    Console.Write("Digite a opção que deseja: ");
    opcao = int.Parse(Console.ReadLine()!);
}

do{
    Exibirmenu();
    switch (opcao){
        case 1:
            Console.Clear();
            Fabricante marca= new Fabricante();
            Console.Write("Digite o nome da fabricante:");
            marca.Nome = Console.ReadLine()!;
            Console.Write("Digite quem é o dono da fabricante:");
            marca.Dono = Console.ReadLine()!;
            Console.Write("Digite em que ano foi criada a fabricante:");
            marca.AnoDeCriacao = int.Parse(Console.ReadLine()!);
            fabricantes.Add(marca);
            break;
        case 2:
            Console.Clear();
            Carro carro = new Carro();
            Console.Write("Digite quem é a fabricante do carro:");
            string nome = Console.ReadLine()!;
            bool achanomefabricante = false;
            foreach(var fabricante in fabricantes){
                if(fabricante.Nome == nome){
                    achanomefabricante = true;
                    carro.Fabricante = nome;
                    Console.Write("Digite o modelo do carro: ");
                    string modelo = Console.ReadLine()!;
                    carro.Modelo = modelo;
                    Console.Write("Digite o preço do carro: ");
                    float preco = float.Parse(Console.ReadLine()!);
                    carro.Preco = preco;
                    Console.Write("Digite o ano de lançamento do carro: ");
                    int AnoDoCarro = int.Parse(Console.ReadLine()!);
                    carro.AnoDoCarro = AnoDoCarro;
                    Console.Write("Digite a quantidade em estoque:");
                    int estoque = int.Parse(Console.ReadLine()!);
                    carro.Estoque = estoque;
                    fabricante.AdicionarCarronaLista(carro);
                    break;
                }
            }
            if(achanomefabricante == false){
                Console.WriteLine("Fabricante não existe!");
                Console.ReadKey();
            }
            break;
        case 3:
            foreach(var fabricante in fabricantes){
                fabricante.ExibirInformacoes();
            }
            Console.ReadKey();
            break;
        case 4:
            Console.Write("Digite o nome do carro que procura:");
            string nomedocarro = Console.ReadLine()!;
            foreach(var fabricante in fabricantes){
                fabricante.MostraCarro(nomedocarro);
            }
            Console.ReadKey();
            break;
        case 0:
            Console.WriteLine("Saindo do sistema...");
            break;
        default:
            Console.Clear();
            Console.Write("Numero Digitado não tem como opção no menu tente novamente!");
            Console.ReadKey();
            break; 
    }
}while(opcao != 0);

