// internal class aluno
// {
//     internal static void ValorMensalidade()
//     {
//         throw new NotImplementedException();
//     }

//     internal static void VerMediaFinal()
//     {
//         throw new NotImplementedException();
//     }
// }

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace atividade_bolsista_POO
{
    public class aluno
    {
        public string Nome;
        public string Curso;
        public string Idade;
        public string RG;
        public bool Bolsistas;
        public float mediaFinal;
        public float ValorMensalidade;

        //pode ser assim com void
        public void VerMediaFinal()
        {
          Console.WriteLine($" A media final aluno {this.Nome} é de {this.mediaFinal}");
           
        }

     // ou fazer com float .. return
        public float VerMensalidade()
        {
           float valor;


           if (this.Bolsistas == true && this.mediaFinal  >= 8)
           {
             valor = this.ValorMensalidade * 0.5f;
           }
            else if(this.Bolsistas == true && this.mediaFinal >6)
           {
             valor = this.ValorMensalidade * 0.7f;
           }
           else{
             valor = this.ValorMensalidade;
           }
  

           return valor;
        }


        



     
       
   }
}