Console.WriteLine(@$"

-----------------------------------------------------
|                   Bebidas                         |
|                                                   |
|     Informe a bebida que deseja:                  |
|                                                   |                         
| '1' Guarana                                      |
| '2'Coca-cola                                     |      
| '3' Monster                                      |
| '4' Cerveja                                      |
| '5' Batida                                       | 
-----------------------------------------------------
");

string bebida;

int menu = int.Parse(Console.ReadLine());


 Console.WriteLine($"Sua é bebida é com gelo? s/n ");
 string gelo = Console.ReadLine();

// float Bebidas = 0;

switch (menu)

{
 case (1):
  bebida = "Guarana" ; 
   Console.WriteLine($" A opçao escolhida foi O Guarana");
   break;
   
   case (2):
   bebida ="Coca-cola";
   Console.WriteLine($" A opçao escolhida foi A Coca-cola");
   break;

   case (3):
   bebida = "Monster";
   Console.WriteLine($" A opçao escolhida foi O Monster");
   break;

   case (4):
   bebida = "Cerveja";
   Console.WriteLine($" A opçao escolhida foi A Cerveja");
   break;

   case (5):
   bebida = "Batida";
   Console.WriteLine($" A opçao escolhida foi A batida");
   break;
  
    default:
    Console.WriteLine($"Numero invalido! ");
     break;
}

if ( gelo == "s")
 {

  Console.WriteLine($"Gelado");
  
}
else 
 {
 Console.WriteLine($"Sem gelo");
 
}
