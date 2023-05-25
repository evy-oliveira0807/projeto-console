
using console_mvc.Model;

namespace console_mvc.View
{
    public class ProdutoView
    {
        //metodo para exibir os dados da lista de produtos
        public void Listar(List<Produto> produtos)
        {
                //foreach para ler a lista passada como parametro do método
            foreach (var item in produtos)
            {
                Console.WriteLine($"\nCódigo: {item.Codigo}");
                Console.WriteLine($"Nome: {item.Nome}");
                Console.WriteLine($"Preço: {item.Preco:C}");
                
                
                
            }
        }

        public Produto Cadastrar()
        {
            Produto novoProduto = new Produto();

            Console.WriteLine($"Informe o código:");
            novoProduto.Codigo = int.Parse(Console.ReadLine());

            Console.WriteLine($"Informe o neme:");
            novoProduto.Nome = Console.ReadLine();

            Console.WriteLine($"Informe o preco:");
            novoProduto.Preco = float.Parse(Console.ReadLine());

            return novoProduto;
            
            
        }
    }
}