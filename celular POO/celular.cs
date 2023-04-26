using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace celular_POO
{
    public class celular
    {
     public string cor;

     public string modelo;

    public  string tamanho;

     public  bool ligado;
     public bool ligar;  

     public string desligar;

     public bool fazerLigacao; 

     public bool enviarMensagem;

    public void ligarCelular()
    {
       Console.WriteLine($"{this.ligar}");
       
    }

    public void desligarCelular()
    {
        Console.WriteLine($"{this.desligar}");
        
    }

    public void Ligacao()
    {
        Console.WriteLine($"{this.fazerLigacao}");
        
    }

    public void mensagem()
    {
         Console.WriteLine($"{this.enviarMensagem}");
         
    }


    }
}