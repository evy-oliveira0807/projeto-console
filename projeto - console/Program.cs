int idade;
int meses;
int horas;
int minutos;
int dias;

Console.WriteLine($"Digite o seu nome: ");
string nome = Console.ReadLine();

Console.WriteLine($"Digite sua idade: ");
 idade = int.Parse (Console.ReadLine());                    

meses = (idade * 12);
dias = (idade * 365);
horas = (dias * 24);
minutos = (horas * 60);

Console.WriteLine($"Sua idade corresponde á: {idade} anos, ou {meses} meses, ou {dias} dias, ou {horas} horas, ou {minutos} minutos!s");

