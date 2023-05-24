

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
    }
}