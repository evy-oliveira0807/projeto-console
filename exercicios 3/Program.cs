//Faça um programa que receba um número inteiro e mostre a sua tabuada.

Console.WriteLine($"Qual tabuada vc quer saber?");

int tabuada = int.Parse(Console.ReadLine());

for (int i = 1; i <= 10; i++)
{
    Console.WriteLine($"{tabuada} x {i} = {tabuada * i}");
    
}









