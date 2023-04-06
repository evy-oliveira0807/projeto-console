Console.WriteLine($"Digite seu nome:");
string nome = (Console.ReadLine());

Console.WriteLine($"Digite sua senha:");
string senha = (Console.ReadLine());

 while (senha == nome)
{
     Console.WriteLine($"Senha ivalida:");
     Console.WriteLine($"Digite uma senha que nao pareça com seu nome:");
      senha = (Console.ReadLine());


    
 }

Console.WriteLine($"Senha valida.");

