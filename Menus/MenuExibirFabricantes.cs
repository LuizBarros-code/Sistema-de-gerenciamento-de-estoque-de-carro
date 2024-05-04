using GERENCIADORCARROS.Modelos;
namespace GERENCIADORCARROS.Menus;
    internal class MenuExibirFabricantes : Menu{

        public override void Executar(List<Fabricante> fabricantes){
            base.Executar(fabricantes);
            ExibirTituloDasOpcoes("Menu para visualização de fabricante");        
            foreach(var fabricante in fabricantes){
                fabricante.ExibirInformacoes();
            }
            Console.ReadKey();
        }
    }
