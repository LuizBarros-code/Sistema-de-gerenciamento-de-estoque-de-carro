using GERENCIADORCARROS.Modelos;
namespace GERENCIADORCARROS.Menus;
    internal class MenuExibirCarro : Menu{
        public override void Executar(List<Fabricante> fabricantes){
            base.Executar(fabricantes);
            ExibirTituloDasOpcoes("Menu de visualização de carro");
            Console.Write("Digite o nome do carro que procura:");
            string nomedocarro = Console.ReadLine()!;
            foreach(var fabricante in fabricantes){
                fabricante.MostraCarro(nomedocarro);
            }
            Console.ReadKey();
        }
    }
