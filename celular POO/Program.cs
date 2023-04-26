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
     Console.WriteLine($"Deseja fazer ligaçao?");
     Console.ReadLine();

     Console.WriteLine($"deseja mandar mensagem?");
     Console.ReadLine();
     
}
else
{
     
    novoCelular.ligar = false;
   
    
}


 Console.WriteLine($"Fim, volte sempre");

  