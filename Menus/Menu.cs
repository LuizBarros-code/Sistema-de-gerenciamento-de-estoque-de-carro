using GERENCIADORCARROS.Modelos;
namespace GERENCIADORCARROS.Menus;

    internal class Menu{
        public void ExibirTituloDasOpcoes(string titulo){
            int quantidadeDeLetras = titulo.Length;
            string asterisco = string.Empty.PadLeft(quantidadeDeLetras,'*');
            Console.WriteLine(asterisco);
            Console.WriteLine(titulo);
            Console.WriteLine(asterisco+"\n");
        }

        public virtual void Executar(List<Fabricante> fabricantes){
            Console.Clear();
        }
    }
