Random numeroAleatorio = new Random(); //gerador de numero aleatorio
int numeroSecreto = numeroAleatorio.Next(1, 100); //gera entre os numeros anotados

Console.WriteLine("benvindo ao Jogo De Advinhação Do Número secreto!!");

do
{
    
    Console.Write("\nEscolha um número de 1 e 100: ");
    int numeroEscolido = int.Parse(Console.ReadLine()); //converte a resposta em int

    if (numeroEscolido == numeroSecreto)
    {
        Console.WriteLine("\nParabéns, você ganhou!!!");
        break;
    }else if (numeroEscolido > numeroSecreto)
    {
        Console.WriteLine("\nO número secreto é menor.");
    }else
    {
        Console.WriteLine("\nO número secreto é maior.");
    }

} while (true); //while para virar loop