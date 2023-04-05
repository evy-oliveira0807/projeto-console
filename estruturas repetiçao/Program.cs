//Faça um programa que leia e valide as seguintes informações:

// 1. Nome: diferente de vazio;

// 2. Idade: entre 0 e 100 anos;

// 3. Salário: maior que zero;

// 4. Estado Civil: 's'(solteiro(a)), 'c'(casado(a)), 'v'(viuvo(a)), 'd'(divorciado(a))


Console.WriteLine($"Digite seu nome:(nao pode deixar em vazio");
string nome = Console.ReadLine();

while (nome.Length == 0)
{
    Console.WriteLine($"O nome nao pode estar vazio, repita");
    nome = Console.ReadLine();
    
}
Console.WriteLine($"Digite sua idade:(entre 0 e 100 anos)");
int idade = int.Parse (Console.ReadLine());

 while (idade < 0  && idade > 100) 
 {
    Console.WriteLine($"Digite sua idade:");
    idade = int.Parse (Console.ReadLine());
    
 }



Console.WriteLine($"Digite seu salario:(maior do que zero)");
float salario = float.Parse  (Console.ReadLine());

 while (salario <
  0)
 {
    Console.WriteLine($"Digite seu salario: (maior de zero)");
    salario = float.Parse  (Console.ReadLine());
    
 }
Console.WriteLine($"Digite seu estado civil: ('s'(solteiro(a)), 'c'(casado(a)), 'v'(viuvo(a)), 'd'(divorciado(a)))");
char civil = char.Parse  (Console.ReadLine());

 while (civil == 's' && civil == 'c' && civil == 'v' && civil == 'd')
 {
    Console.WriteLine($"Digite seu estado civil: ('s'(solteiro(a)), 'c'(casado(a)), 'v'(viuvo(a)), 'd'(divorciado(a)))");
    civil = char.Parse  (Console.ReadLine());
    
 }

 Console.WriteLine($"Seu nome é {nome}, Sua idade é {idade} anos, Seu salario é de {salario} reais e Seu estado civil é {civil}");
 




