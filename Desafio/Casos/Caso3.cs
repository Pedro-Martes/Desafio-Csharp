
namespace Desafio.Casos;

public class Caso3 {
    public void Calc(double valor1,double valor2) {
        double soma = valor1 + valor2;
        Console.WriteLine($"A soma dos valores é: {soma} ");

        double sub;
        if(valor1 > valor2) {
            sub = valor1 - valor2;
        } else {
            sub = valor2 - valor1;
        }
        Console.WriteLine($"A subtracao dos valores eh: {sub}");

        double multi = valor2 * valor1;
        Console.WriteLine($"A multiplicacao entre os valores eh: {multi}");

        if(valor2 == 0) {
            Console.WriteLine("A divisao entre os numeros eh impossivel devido ao valor 2 ser 0.");
        } else {
            double divisao = valor1 / valor2;
            Console.WriteLine($"a divisao entre os valores eh: {divisao}");
        }

        double media = (valor1 + valor2) / 2;
        Console.WriteLine($"A media entre os dois valores eh: {media}");
    }
}
