

using console_mvc.Model;
using console_mvc.View;

namespace console_mvc.Controller
{
    public class ProdutoController
    {
        //instanciar objeto produto e produtoView

        Produto produto = new Produto();
        ProdutoView produtoView = new ProdutoView();

        public void ListarProdutos()
        {
            List<Produto> produtos = produto.Ler();

            //chamada do metodo de exibicao(VIEM) recebendo como argumento 
            produtoView.Listar(produtos);
        }

        //metodo controlador para acessar o cadastro do produto 

        public void CadastrarProduto()
        {

            //chamada para a a view que recebe cada objeto a ser inserido no csv
            Produto novoProduto = produtoView.Cadastrar();

            //chamda para a model para inserir esse objeto no csv
            produto.inserir(novoProduto);

        }
    }
}