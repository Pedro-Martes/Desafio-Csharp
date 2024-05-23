namespace Desafio.Casos;

public class Caso2 {

    public void Surname(string Name) {
        Console.WriteLine("2 - Informe o seu sobrenome: ");
        string Surname = Console.ReadLine();
        Console.WriteLine($"{Name} {Surname}");
    }
}
