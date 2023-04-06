


    Console.WriteLine($"digite uma nota entre 0 e 10:");
    int nota  = int.Parse(Console.ReadLine());

  while (nota < 0 || nota > 10)
  {
    Console.WriteLine($"Nota invalida:");
    Console.WriteLine($"Digite apenas notas entre 0 e 10:");
     nota  = int.Parse(Console.ReadLine());
    
  }

  Console.WriteLine($"oba, vc digitou a nota correta, obgd até mais.");

  




    
   
    