Console.WriteLine($"Digite o numero de maças compradas");
float maças = float.Parse (Console.ReadLine( ));

float macasduzia = 0.25f;
float macasonze = 0.30f;

if (maças >= 12)
{
    float valor= maças * macasduzia; 
 Console.WriteLine($"R${valor}");
 
}

else
{
    float valor= maças *  macasonze;
    Console.WriteLine($"R${valor}");
}

