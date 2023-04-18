// Criar uma aplicação para uma agência de turismo, no qual deveremos registrar passagens aéreas com os seguintes dados: Nome do passageiro, Origem, Destino e Data do Voo de 5 passageiros.

// Antes de entrar no sistema faça um esquema do qual o usuário só possa acessar o menu se a senha for igual à 123456.
// O sistema deve exibir um menu com as seguintes opções:

// 1- Cadastrar passagem
// 2- Listar Passagens
// 0- Sair


//Declaracao de variavel

string[] nomes = new string[5];
string[] origem = new string[5];
string[] destino = new string[5];
string[] data = new string[5];
string nome;
string senha;
string resposta;




//PROCESSAMENTO




static bool Login(string senha)
{

 if (senha ==  "123456")
 {
   Console.WriteLine($"Senha aceita");
    return true;
 }
 else
 {
  Console.WriteLine($"Senha nao aceita");
   return false;
 }
}


bool senhavalida;

do
{
Console.WriteLine($"***Bem vindos a Agência de Viagens!***");

 Console.WriteLine($"Informe a senha:");
 senha = (Console.ReadLine());
  senhavalida = Login(senha);
  
} while (senhavalida == false);
           
  Console.WriteLine(@$"
 ------------------------------------
 |    Selecione uma opção:           | 
 |                                   |
 |  '1' Cadastrar Passagem           |
 |  '2' Listar Passagens             |  
 |  '0' Sair                         |
 |                                   |
 -------------------------------------
 ");


   string escolha = Console.ReadLine();
     

   switch (escolha)
   {
     case "1":
      
      do
      {
       for (var i = 0; i < 5; i++)
       {
          Console.WriteLine($"Informe o seu nome:");
          nomes[i] = Console.ReadLine();

          Console.WriteLine($"Informe sua origem:");
          origem[i] = Console.ReadLine();

          Console.WriteLine($"Informe o destino:");
          destino[i] = Console.ReadLine();

          Console.WriteLine($"Informe a data:");
         data[i] = Console.ReadLine();



         
          
        }
        
       Console.WriteLine($"Gostaria de cadastrar uma nova passagem? s/n");
        resposta = Console.ReadLine();
       
      } while (resposta == "s");
   break;
      case "2":
      for (var i = 0; i < 5; i++)
      {
        Console.WriteLine(@$"
        
       *** Bilhete de passagem ***

        nome: {nomes[i]}
        origem: {origem[i]}
        destino: {destino[i]}
        data: {data[i]}
        
        ");
        
      }
      break;
 
       case "0":
        Console.WriteLine($"Fim");
        break;
    default:
        Console.WriteLine($"Opção inválida");
        break;
}
 while (escolha != "0");
    
     
    
  




