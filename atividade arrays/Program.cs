// exercicios de fixaçao

//excreva um programa que receba e imprima o nome e idade de 5 pessoas

//exemplo de exibiçao

//1) nome: carlos
//idade: 36 anos

//2) nome: carlos
//idade: 36 anos

//3) nome: carlos
//idade: 36 anos

//4) nome: carlos
//idade: 36 anos

//5) nome: carlos
//idade: 36 anos


string[] nome = new string[5];
int[] idade = new int[5];

for (int i = 0; i < 1; i++)
{
    
    Console.WriteLine($"1) Nome:");
    nome[i]= Console.ReadLine();
    Console.WriteLine($"Idade:");
    idade[i]= int.Parse (Console.ReadLine());
    
    
    Console.WriteLine($"2) Nome:");
    nome[i]= Console.ReadLine();
    Console.WriteLine($"Idade:");
    idade[i]= int.Parse (Console.ReadLine());
    
    Console.WriteLine($"3) Nome:");
    nome[i]= Console.ReadLine();
    Console.WriteLine($"Idade:");
    idade[i]= int.Parse (Console.ReadLine());

    
    Console.WriteLine($"4) Nome:");
    nome[i]= Console.ReadLine();
    Console.WriteLine($"Idade:");
    idade[i]= int.Parse (Console.ReadLine());
    
    Console.WriteLine($"5) Nome:");
    nome[i]= Console.ReadLine();
    Console.WriteLine($"Idade:");
    idade[i]= int.Parse (Console.ReadLine());
    
      
}

