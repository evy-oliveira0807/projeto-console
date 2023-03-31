Console.WriteLine($"digita a medidas de lado A: ");
string ladoA =  Console.ReadLine ();
Console.WriteLine($"digita a medidas de lado B: ");
string ladoB =  Console.ReadLine ();
Console.WriteLine($"digita a medidas de lado C: ");
string ladoC =  Console.ReadLine ();



if ( (ladoA == ladoB) && ( ladoB == ladoC))
{
 Console.WriteLine($"equilatero");
 
}
  else if ((ladoA == ladoB) || (ladoB == ladoC) )
  {
    Console.WriteLine($" Isóscele");
    
  }

  else if ((ladoA != ladoB) &&  (ladoB!= ladoC) )
  {
    Console.WriteLine($"Escaleno");
    
  }






