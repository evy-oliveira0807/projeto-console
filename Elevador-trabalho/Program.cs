// Crie uma classe abstrata denominada Elevador para armazenar as informações de um elevador
// dentro de um prédio. \\\

// A classe deve armazenar o andar atual (térreo = 0), total de andares no prédio (desconsiderando o térreo), capacidade do elevador e quantas pessoas estão presentes nele.

// A classe deve também disponibilizar os seguintes métodos:

// Inicializa : que deve receber como parâmetros a capacidade do elevador e o total de andares no prédio (os elevadores sempre começam no térreo e vazio);

// Entrar : para acrescentar uma pessoa no elevador (só deve acrescentar se ainda houver espaço);

// Sair : para remover uma pessoa do elevador (só deve remover se houver alguém dentro dele);

// Subir : para subir um andar (não deve subir se já estiver no último andar);

// Descer : para descer um andar (não deve descer se já estiver no térreo);

// Encapsular todos os atributos da classe (criar os métodos set e get).

// Crie também duas subclasses: ELEVADORSOCIAL e ELEVADORSERVIÇO, o elevador de serviço deve ter um método altere o numero de caixas dentro dele.


using Elevador_trabalho;
Elevador novoElevador = new Elevador();





string opcao = (Console.ReadLine());

do
{
    Console.WriteLine(@$"

* * * * * * * * * * * * * * * * * *
*       selecione uma opçao:      *
                                
*    '1'  Entrar pessoas          *
   
*     '2' Sair pessoas            *

*     '3' Subir                   *

*     '4' Descer                  *
* * * * * * * * * * * * * * * * * *

");


    switch (opcao)
    {
        case "1":


            Console.WriteLine($"Entrar");
            Console.ReadLine();

            novoElevador.Entrada();
break;


        case "2":
            Console.WriteLine($"Sair");
             Console.ReadLine();

            novoElevador.Saida();

            break;

        case "3":

            Console.WriteLine($"subida");
             Console.ReadLine();

            novoElevador.subida();

            Console.WriteLine(@$"

  * * * * * * * * * * * * * * * * * * * * * *

 *    Aperte o botão com o andar desejado  *

 *    '1' Primeiro andar                   *

 *    '2'Segundo andar                     *

 *    '3' Terceiro andar                   *

 *    '4' Quarto andar                     *

 * * * * * * * * * * * * * * * * * * * * * * 
  ");



            switch (opcao)
            {
                case "1":
                    Console.WriteLine($"Você chegou no primeiro andar");
                     Console.ReadLine();

                    break;

                case "2":
                    Console.WriteLine($"Você chegou no segundo andar");
                     Console.ReadLine();
                    break;

                case "3":
                    Console.WriteLine($"Você chegou no terceiro andar");
                     Console.ReadLine();
                    break;

                case "4":
                    Console.WriteLine($"Você chegou no quarto andar");
                     Console.ReadLine();
                    break;


                default:
                    Console.WriteLine($"Nao existe esse andar nesse predio!");
                     Console.ReadLine();

                    break;
            }

            break;

            break;

        case "4":

            novoElevador.Descida();
             Console.ReadLine();
             Console.WriteLine(@$"

  * * * * * * * * * * * * * * * * * * * * * *

 *    Aperte o botão com o andar desejado  *

 *    '1' Primeiro andar                   *

 *    '2'Segundo andar                     *

 *    '3' Terceiro andar                   *

 *    '4' Quarto andar                     *

 * * * * * * * * * * * * * * * * * * * * * * 
  ");



            switch (opcao)
            {
                case "1":
                    Console.WriteLine($"Você chegou no primeiro andar");
                     Console.ReadLine();
                    break;

                case "2":
                    Console.WriteLine($"Você chegou no segundo andar");
                     Console.ReadLine();
                    break;

                case "3":
                    Console.WriteLine($"Você chegou no terceiro andar");
                     Console.ReadLine();
                    break;

                case "4":
                    Console.WriteLine($"Você chegou no quarto andar");
                     Console.ReadLine();
                    break;


                default:
                    Console.WriteLine($"Nao existe esse andar nesse predio!");
                     Console.ReadLine();

                    break;
            }

            break;


            break;

        default:
            Console.WriteLine($"Digito invalido!");
          

            break;
    }
} while (opcao != "1");





















