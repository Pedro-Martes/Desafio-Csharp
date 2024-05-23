namespace Desafio.Casos;

public class Caso4 {
    public Caso4 (string phrase) {
        
        var phraseNoSpaces = phrase.Replace(" ", "");

      
        Console.WriteLine($"A frase possui {phraseNoSpaces.Length} letras.");

        
       
    }
}
