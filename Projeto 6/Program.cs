
float media;
float frequencia;

Console.WriteLine($"Entre com a nota media do aluno (%): ");
media = float.Parse(Console.ReadLine());

Console.WriteLine($"Entre com a frequencia do aluno (%): ");
 frequencia = float.Parse(Console.ReadLine());

 if( media >= 7.0F && (frequencia/100) >= 0.75F)
 {
    Console.WriteLine($"Aluno aprovado!");

 }

 else if ((media > 3.0F && media <7.0F) && (frequencia/100) >= 0.75F)
{
    Console.WriteLine($"aluno em recuperaçao!");
    
}
else
{
    Console.WriteLine($"Aluno reprovado!");
    
}



