using System.Globalization;

namespace Desafio.Casos;

public class Caso6 {
    public void DateFormat(string dateSelected) {
        

        DateTime data1 = DateTime.Now;

        switch(dateSelected) {
            case "1": {
                    Console.WriteLine(data1.ToString("D",new CultureInfo("pt-BR")));
                    break;
                }
                case "2": {
                    Console.WriteLine(data1.ToString("d",new CultureInfo("pt-BR")));
                    break;
                }
                case "3": {
                    Console.WriteLine(data1.ToString("HH':'mm':'ss",new CultureInfo("pt-BR")));
                    break;
                }
                case "4": {
                    Console.WriteLine(data1.ToString("d ', de 'MMMM', 'yyyy"));
                    break;
                }
                default: {
                    Console.WriteLine("Insira uma opção valida");
                    break;
                }
        }

    }
}
