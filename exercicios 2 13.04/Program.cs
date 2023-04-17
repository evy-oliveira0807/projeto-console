﻿//Um posto está vendendo combustíveis com a seguinte tabela de descontos:
// Álcool:
// . até 20 litros, desconto de 3% por litro Álcool
// . acima de 20 litros, desconto de 5% por litro
// Gasolina:
// . até 20 litros, desconto de 4% por litro Gasolina
// . acima de 20 litros, desconto de 6% por litro

// Escreva um algoritmo que leia o número de litros vendidos e o tipo de combustível (codificado
// da seguinte forma: A-álcool, G-gasolina), calcule e imprima o valor a ser pago pelo cliente
// sabendo-se que o preço do litro da gasolina é R$ 5,30 e o preço do litro do álcool é R$ 4,90.
// Dica: utilize switch case e funções/métodos para otimizar o algorítimo.



//DECLARACAO DE VARIAVEL 
 Console.Clear();
 Console.WriteLine($"ola bem vindo ao posto ");

 float precoLitroAlcool = 4.90f;
 float precoLitroGasolina = 5.30f;

 float quantidadeLitroAlcool;
 float quantidadeLitroGasolina;

 float valorAbastecimento;

 char opcao;

//PROCESSAMENTO
static float Alcool(float quantidade, float preco)
 {
     if (quantidade <= 20)
     {
         return (quantidade * preco) * 0.97f;
     }
     else
     {
         return (quantidade * preco) * 0.95f;
     }
 }

 static float Gasolina(float quantidade, float preco)
 {
     if (quantidade <= 20)
     {
         return (quantidade * preco) * 0.96f;
     }
     else
     {
         return (quantidade * preco) * 0.94f;
     }
 }
 do
 {
     Console.WriteLine(@$"
 -------------------------
 |   Combustível:        |
 |                       |
 | (a) - álcool          |
 | (g) - gasolina        |
 |                       |
 -------------------------
 ");
    opcao = char.Parse(Console.ReadLine());

     switch (opcao)
     {
         case 'a':
             Console.WriteLine($"Qual sera a quantidade de álcool em litros que vc deseja: ");
             quantidadeLitroAlcool = float.Parse(Console.ReadLine());

             valorAbastecimento = Alcool(quantidadeLitroAlcool, precoLitroAlcool);

             Console.WriteLine($"O valor do abastecimento é : {valorAbastecimento} ");

             break;
         case 'g':
             Console.WriteLine($"Qual sera a quantidade de gasolina em litros que vc deseja: ");
             quantidadeLitroGasolina = float.Parse(Console.ReadLine());

             valorAbastecimento = Alcool(quantidadeLitroGasolina, precoLitroGasolina);

             Console.WriteLine($"O valor do abastecimento é : {valorAbastecimento} ");
             break;
         default:
             Console.WriteLine($"Digito invalido!");
             break;
     }
 } while (opcao != 'a' && opcao != 'g');





