
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
    }
}