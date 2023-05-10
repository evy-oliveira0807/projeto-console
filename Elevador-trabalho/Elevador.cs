using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Elevador_trabalho
{
    public  class Elevador
    {

        public string predio;

        public float térreo = 0;

        public float inicializar{get; set;}

        public float andarespredio = 4;

        public string Entrar;

        public float Sair;
        public float Subir;

        public float Descer;

        public float totalPessoa = 5;
        private object descer;

        public void andartérreo()
        {
          Console.WriteLine($"{térreo}");

          térreo=0;
         
        }
        public void Entrada()
        {
            Console.WriteLine($"{Entrar}");
            
        }

        public void Saida()
        {
            Console.WriteLine($"{Sair}");
            
        }

                public void subida()
        {
            Console.WriteLine($"{Subir}");
            
        }

        public void Descida()
        {
            Console.WriteLine($"{Descer}");
            
        }

      
        // internal void Entrar()
        // {
        //     throw new NotImplementedException();
        // }

        // internal void Descer()
        // {
        //     throw new NotImplementedException();
        // }

        // internal void Sair()
        // {
        //     throw new NotImplementedException();
        // }
    }
}


