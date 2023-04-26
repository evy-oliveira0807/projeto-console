using celular_POO;
celular novoCelular = new celular ();

// Crie uma Classe de um Celular, com as propriedades cor, modelo, tamanho, ligado(booleano).
// Com os métodos, ligar, desligar, fazer ligação, enviar mensagem.
// Só será possível executar tais métodos se o celular estiver ligado.
// Envie o link do repositório como entrega desta atividade.


Console.WriteLine($"Qual é a cor do Celular:");
novoCelular.cor = Console.ReadLine();

Console.WriteLine($"Qual é o modelo do Celular:");
novoCelular.modelo = Console.ReadLine();

Console.WriteLine($"Qual é o tamanho do Celular:");
novoCelular.tamanho = Console.ReadLine();

Console.WriteLine($"Deseja ligar o celular? (s/n) :");
string resposta = Console.ReadLine().ToLower();



if ( resposta == "s")
{
     
     novoCelular.ligar = true;
     Console.WriteLine($"Deseja fazer ligaçao? (s/n)");
     string resposta2 = Console.ReadLine();
     

     if (resposta2 == "s")
     {
        novoCelular.fazerLigacao = true;
     }
     else
     {
        novoCelular.fazerLigacao = false;

        Console.WriteLine($"Nao fazer ligaçao!");
        
     }


     Console.WriteLine($"deseja mandar mensagem? (s/n)");
     string resposta3 =  Console.ReadLine();
     
     if (resposta3 == "s")
     {
        novoCelular.enviarMensagem = true;
     }
     else 
     {
         novoCelular.enviarMensagem = false;
         Console.WriteLine($"Nao enviar mensagem!");
         
     }
}
else
{
     
    novoCelular.ligar = false;
   
    
}


 Console.WriteLine($"Fim, volte sempre");

   
 