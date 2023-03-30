// Console.WriteLine(@$"
//     -----------------
//     |      Nota     |
//     |               | 
//     -----------------


// ");

Console.WriteLine($"Digite a 1ª nota");
float nota1 = float.Parse (Console.ReadLine ());

Console.WriteLine($"Digite a 2ª nota");
float nota2 = float.Parse (Console.ReadLine ());

Console.WriteLine($"Digite a 3ª nota");
float nota3 = float.Parse (Console.ReadLine ());

Console.WriteLine($"Digite a 4ª nota");
float nota4 = float.Parse (Console.ReadLine ());

Console.WriteLine($"Digite a 5ª nota");
float nota5 = float.Parse (Console.ReadLine ());

float media = (nota1 + nota2 + nota3 + nota4 + nota5) / 5;

Console.WriteLine($"a nota final corresponde á: 1ª nota + 2ª nota + 3ª nota + 4ª nota + 5ª nota ");

Console.WriteLine($"A nota do aluno {media} tem imc igual á: {5}");



