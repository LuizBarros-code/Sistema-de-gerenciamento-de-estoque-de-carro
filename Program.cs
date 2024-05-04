
using GERENCIADORCARROS.Modelos;
using GERENCIADORCARROS.Menus;

internal class Program{
private static void Main(string[] args){

    List<Fabricante> fabricantes = new List<Fabricante>();

    int opcao;



    Dictionary<int, Menu> opcoes = new();
    opcoes.Add(1, new MenuFabricante());
    opcoes.Add(2, new MenuCarro());
    opcoes.Add(3, new MenuExibirFabricantes());
    opcoes.Add(4, new MenuExibirCarro());
    opcoes.Add(0, new MenuSair());

    void ExibirOpcoesDoMenu(){
        Console.Clear();
        Console.WriteLine("*******************************");
        Console.WriteLine("GERENCIADOR DE ESTOQUE DE CARRO");
        Console.WriteLine("*******************************");
        Console.WriteLine("1-Criar nova fabricante");
        Console.WriteLine("2-Adicionar carro");
        Console.WriteLine("3-Visualizar fabricante");
        Console.WriteLine("4-Visualizar carro");
        Console.WriteLine("0-Para sair do sistema");
        Console.WriteLine("*******************************");
        Console.Write("Digite a opção que deseja: ");
        opcao = int.Parse(Console.ReadLine()!);
        if(opcoes.ContainsKey(opcao)){
            Menu menuASerExibido = opcoes[opcao];
            menuASerExibido.Executar(fabricantes);
        if(opcao > 0) ExibirOpcoesDoMenu();
        }else{
            Console.Write("Numero Digitado não tem como opção no menu tente novamente!");
        }
    }
    ExibirOpcoesDoMenu();
}
}

  