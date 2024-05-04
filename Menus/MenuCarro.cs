using GERENCIADORCARROS.Modelos;
namespace GERENCIADORCARROS.Menus;
    internal class MenuCarro : Menu{
        public override void  Executar(List<Fabricante> fabricantes){
            base.Executar(fabricantes);
            ExibirTituloDasOpcoes("Menu de adicionar carro");
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
        }
    }
