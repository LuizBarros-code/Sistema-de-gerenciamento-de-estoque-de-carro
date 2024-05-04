using GERENCIADORCARROS.Modelos;
namespace GERENCIADORCARROS.Menus;

internal class MenuSair : Menu{

    public override void Executar(List<Fabricante> fabricantes){
        Console.WriteLine("Saindo do sistema...");
    }
}