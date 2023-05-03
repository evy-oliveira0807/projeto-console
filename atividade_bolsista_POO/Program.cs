using atividade_bolsista_POO;
aluno novoAluno = new aluno ();

Console.WriteLine($"Digite o nome do aluno:");
novoAluno.Nome = (Console.ReadLine());

Console.WriteLine($"Digite o curso do aluno:");
novoAluno.Curso = Console.ReadLine();

Console.WriteLine($"Digite a idade do aluno:");
novoAluno.Idade = Console.ReadLine();

Console.WriteLine($"Digite o RG do aluno:");
novoAluno.RG = Console.ReadLine();

Console.WriteLine($"digite a media das notas do aluno:");
novoAluno.mediaFinal = float.Parse (Console.ReadLine());

Console.WriteLine($"digite o valor da mensalidade:");
novoAluno.ValorMensalidade = float.Parse (Console.ReadLine());

Console.WriteLine($"O aluno é bolsista ? (s/n) :");
 string resposta =  Console.ReadLine().ToLower();


 // ou pode ser
 //      novoAluno.bolsista = resposta =="s" ? true: false;

 //para o sim e nao de pergunta 

 //ouu  novoAluno.bolsista == "s"


 

if (resposta == "s")
{
    novoAluno.Bolsistas = true;
}
else
{
    novoAluno.Bolsistas = false;
}



    string opcao = Console.ReadLine();
do
{
    
Console.WriteLine(@$"

 -----------------------------------
|                                   |
|      Selecione a opcao desejada:  |
|                                   |
|   '1' - Ver media do aluno        |
|   '2' - Ver valor da mensalidade  |
|   '0' - Sair                      |
  ----------------------------------
");

 opcao = Console.ReadLine();

 switch (opcao)
 {
    case "1":
          Console.WriteLine($"A media do aluno {novoAluno.Nome} é {novoAluno.mediaFinal}");
              
        break;

    case"2":
            Console.WriteLine($"O valor da mensalidade do {novoAluno.Nome} é de {novoAluno.ValorMensalidade }");
             
         break;

    case"0" :   

         Console.WriteLine($"Obrigado por utilizar nosso sistema, até logo.");
         
         break;
    default:
          Console.WriteLine($"Digito invalido!");
          
        break;
 }
 
} while (opcao != "0");

