Console.WriteLine($" Quantos gol fez o time A");
float timeA = float.Parse (Console.ReadLine());                    

Console.WriteLine($" Quantos gol fez o time B");
float timeB = float.Parse (Console.ReadLine());  

if (timeA < timeB)
{

    Console.WriteLine($"Time B ganhou");
    
}

else
{
    Console.WriteLine($"Time A ganhou");
    

}

if ( timeA == timeB)

{
 Console.WriteLine($"Deu empate");
 
}