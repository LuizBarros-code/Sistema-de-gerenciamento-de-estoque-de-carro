namespace GERENCIADORCARROS.Modelos{
class Fabricante {
    private string _nome = "";
    private int _anodecriacao;
    private string _dono = "";
    private List<Carro> _carros = new List<Carro>();

    public string Nome{ 
        get{
            return _nome; 
        } 
        set{
            _nome = value;
        } 
    }
    public int AnoDeCriacao{ 
        get{
            return _anodecriacao;
        } 
        set{
            _anodecriacao = value;
        } 
    }
    public string Dono{ 
        get{
            return _dono;
        } 
        set{
            _dono = value;
        } 
    }

    public void AdicionarCarronaLista(Carro carro){
        _carros.Add(carro);
    }

    public void MostraCarros(){
        foreach(var Carro in _carros){
            Console.WriteLine($"A fabricante: {Carro.Fabricante}, modelo: {Carro.Modelo}, preço: {Carro.Preco}, Fabricado no ano: {Carro.AnoDoCarro}, Quantidade em estoque: {Carro.Estoque}");
        }
    }

    public void MostraCarro(string carro){
        foreach(var Carro in _carros){
            if(carro == Carro.Modelo){
                Console.WriteLine($"A fabricante: {Carro.Fabricante}, modelo: {Carro.Modelo}, preço: {Carro.Preco}, Fabricado no ano: {Carro.AnoDoCarro}, Quantidade em estoque: {Carro.Estoque}");
            }
        }
    }
    public void ExibirInformacoes(){
        Console.WriteLine($"A fabricante de carros {Nome} de {Dono}, Criada em {AnoDeCriacao} tem os carros: ");
        foreach( var carros in _carros){
            Console.WriteLine($"carro: Modelo-{carros.Modelo}, Preço-{carros.Preco}, Ano do carro: {carros.AnoDoCarro}, Quantidade em estoque: {carros.Estoque} ");
        }

    }    


    }
}
