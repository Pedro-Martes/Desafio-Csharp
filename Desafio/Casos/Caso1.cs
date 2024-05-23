namespace Desafio.Casos;

public class Caso1 {
    public string Name() {
        Console.WriteLine("1 - Digite o seu nome:");
        string nome = Console.ReadLine();
        Console.WriteLine($"Olá {nome} Seja muito bem-vindo!");
        return nome;
    }
}
