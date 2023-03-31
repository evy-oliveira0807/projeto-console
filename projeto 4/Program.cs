Console.WriteLine($"Digite a senha:");
float senhadigitada = float.Parse ( Console.ReadLine ());

int senhacorreta = 1234;

if (senhadigitada == senhacorreta)
{
    Console.WriteLine($"Permitido");
    
}
else
{
    Console.WriteLine($"Negado");
    
}