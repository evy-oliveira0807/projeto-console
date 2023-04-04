//Vamos criar uma calculadora usando switch case

//Logica - Algoritimo

//1. definir operaçao
//2. informar o primeiro numero
//3. informar o segundo numero
//4. processar os dados inseridos
//5. exibir o resultado

//entrada

Console.WriteLine(@$"

-----------------------------------------------------
|             Programar Calculadora                 |
|Informe a operaçao matematica  que deseja efetuar: |                         
| '+' para somar                                    |
| '*' para multiplicar                              |      
| '-' para subtrair                                 |
| '/' para dividir                                  | 
-----------------------------------------------------
");

//recebe a operacao escolhida
char operacao = char.Parse(Console.ReadLine());

//entrada do primeiro numero
Console.WriteLine($"Digite o primeiro numero: ");
float numero1 = float.Parse(Console.ReadLine());


//entrada do segundo numero
Console.WriteLine($"Digite o segundo numero: ");
float numero2 = float.Parse(Console.ReadLine());

//declarando a variavel que recebera o resultado
float resultado = 0;

//Processamento

switch (operacao)
{
  case '+':
       resultado = (numero1 + numero2);
       Console.WriteLine($"O resultado da soma é (resultado) ");
       break;

    case '*':

       resultado = (numero1 + numero2);
       Console.WriteLine($"O resultado da soma é (resultado) ");
       break;

    case '-' :
       resultado = (numero1 + numero2);
       Console.WriteLine($"O resultado da soma é (resultado) ");
       break;

    case '/': 
       resultado = (numero1 + numero2);
       Console.WriteLine($"O resultado da soma é (resultado) ");
       break;
    
    default:
      Console.WriteLine($"A operaçao informada nao é suportada pela nossa calculadora! ");
     break;
}



    

   
    







