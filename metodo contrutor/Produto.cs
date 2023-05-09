using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace metodo_contrutor
{

    //propriedades
   public class Produto
    {
        public string Nome {get; set; }

        public int Codigo {get; set; }

        public int Estoque {get; set;}

        //metodo construtor vazio
  
  public Produto()
  {

  }

  //metodo construtor passando o codigo como obrigatorio

  public Produto(int codigo)
  {
    codigo = codigo;
  }
  //metodo construtor passando todas as propriedades como obrigacoes

  public Produto ( string nome, int codigo, int Estoque)
  {
    Nome = nome;
    Codigo = codigo;
    Estoque = Estoque;
  }

    }
}