using GERENCIADORCARROS.Modelos;
namespace GERENCIADORCARROS.Menus;
    internal class MenuFabricante : Menu{
        public override void Executar(List<Fabricante> fabricantes){
            base.Executar(fabricantes);
            ExibirTituloDasOpcoes("Menu de adicionar Fabricante");
            Fabricante marca= new Fabricante();
            Console.Write("Digite o nome da fabricante:");
            marca.Nome = Console.ReadLine()!;
            Console.Write("Digite quem é o dono da fabricante:");
            marca.Dono = Console.ReadLine()!;
            Console.Write("Digite em que ano foi criada a fabricante:");
            marca.AnoDeCriacao = int.Parse(Console.ReadLine()!);
            fabricantes.Add(marca);
        }
    }
