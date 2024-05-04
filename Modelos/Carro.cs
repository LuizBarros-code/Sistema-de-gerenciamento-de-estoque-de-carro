
namespace GERENCIADORCARROS.Modelos{
class Carro{
    private string _fabricante = "";
    private string _modelo = "";
    private float _preco;
    private int _anodocarro;

    private int _estoque;

   public string Fabricante { 
        get{
            return _fabricante; 
        }
        set{
            _fabricante = value;
        } 
   }

   public string Modelo {
        get{
            return _modelo;
        }
        set{
            _modelo = value;
        }
   }  

   public float Preco {
        get{
            return _preco;
        }
        set {
            _preco = value;
        }
   }

    public int AnoDoCarro{
        get{
            return _anodocarro;
        }
        set{
            if((value >= 1960) && (value <= 2024)){
                _anodocarro = value;
            }else{
                Console.Write("Ano invalido!");
            }
        }
    }

    public int Estoque{
        get{
            return _estoque;
        }
        set
        {
        _estoque = value; 
        }
    }
    public void DescricaoDetalhada() => Console.WriteLine($"Carro da {Fabricante}, Modelo {Modelo}, Ano: {AnoDoCarro}, Quantidade em estoque: {Estoque}");
}
}
