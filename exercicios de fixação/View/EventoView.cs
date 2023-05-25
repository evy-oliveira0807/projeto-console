using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using exercicios_de_fixação.Model;

namespace exercicios_de_fixação.View
{
    public class EventoView
    {
        public void Listar(List<Evento> eventos)
        {
          foreach(var item in eventos)
          {
            Console.WriteLine($"Nome: {item.Nome}");

            Console.WriteLine($"Descrição: {item.Descricao}");

            Console.WriteLine($"Data: {item.Data}");
              
          }
            
        }

        public Evento Cadastrar()
        {
            Evento novoEvento = new Evento();

            Console.WriteLine($"INforme o nome do evento:");
            Console.WriteLine($"Informe a descriçào do evento:");

            Console.WriteLine($"Informe a data do evento:");
            
            return novoEvento;
            
            
        }
    }
   
      
       
}