// Ler o ano atual e o ano de nascimento de uma pessoa. Escrever uma mensagem que diga se
// ela poderá ou não votar este ano (não é necessário considerar o mês em que a pessoa nasceu).


// //DECLARACAO DE VARIAVEL 
// int anoAtual, nascimento, idade;

// //INICIALIZACAO DE UMA VAREALVEL
//  anoAtual = 1; 
//  nascimento = 10;
//  anoAtual = 20;
//  nascimento = 60;
//  anoAtual = 5;
//  idade = 0;


// //PROCESSAMENTO
//  if(false)
//  {
//  idade = anoAtual + nascimento;
//  }

// //SAIDA
// /* idade = 120; */
// Console.WriteLine($"A sua idade é {idade}:");


//declaracao de variavel
int anoAtual, anoNascimento, idade;

//inicializacao de uma variavel

anoAtual=2023;


// processamento

Console.WriteLine($"Digite seu ano de nascimento:");
anoNascimento = int.Parse(Console.ReadLine());

idade = anoAtual - anoNascimento;

if (idade >= 16)
{
    Console.WriteLine($"Você tem {idade} anos, você podera votar esse ano:)");
    
}
else
{
    Console.WriteLine($"Você tem {idade} anos, você nao podera votar esse ano :(");
    
}









