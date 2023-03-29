// string name = "evelyn";
// Console.WriteLine(name);

// int idade = 17;
// Console.WriteLine("A idade da " + name + " é " + idade + " anos " );

// float preco = 10.95f;

// bool careca = false;
// Console.WriteLine(careca);

//operadores

//Soma

// Console.WriteLine(5 + "4");
// //Console.WriteLine(5 + x );


// //subtracao

// Console.WriteLine(15 - 3);

// //multiplicacao

// Console.WriteLine(5 * 5);


// //divisao
// Console.WriteLine(10 / 10);

// //igual a
// Console.WriteLine(5 >= 4); 

// //maior ou igual a
// Console.WriteLine(5 >= 10);

// //menor ou igual a
// Console.WriteLine(4 <= 10);

// // maior que
// Console.WriteLine(150 > 95);


// //menor que
// Console.WriteLine(150< 54);



//crie um programa para calcular o IMC de uma pessoa

//Algoritimo
//entrada: Nome, idade , peso, altura
//processamento: peso dividido poraltura ao quadrado

string nome = "evelyn";
int idade = 17;
float peso = 77;
float altura = 1.80f;

//processamento
float imc = peso / (altura * altura);

//saida 
Console.WriteLine ($"o IMC do(a) "  + nome + " é de " + Math.Round(imc,2));
















