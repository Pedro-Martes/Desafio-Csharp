using Desafio.Casos;

namespace Desafio {

    class Program {
        static void Main(string[] args) {
           
            Console.WriteLine("Desafio 1:");
            Caso1 caso1 = new Caso1();
            string userName = caso1.Name();

            Caso2 caso2 = new Caso2();
            caso2.Surname(userName);

            Caso3 caso3 = new Caso3();
            Console.WriteLine("Digite o valor  1 par o calculo:");
            var val1 = Console.ReadLine();
            Console.WriteLine("Digite o valor  2 par o calculo:");
            var val2 = Console.ReadLine();
            double value1 = 0;
            double value2 = 0;
            try {

                value1 = Convert.ToDouble(val1);
                value2 = Convert.ToDouble(val2);

            } catch(Exception ex) {
                Console.WriteLine(ex.ToString());
                return;
            }
          
            caso3.Calc(valor1: value1,valor2: value2);
            Console.WriteLine("4 - Digite uma frase:  ");
            string phrase = Console.ReadLine();
            Caso4 caso4 = new Caso4(phrase); 
            Caso5 caso5 = new Caso5();
            Console.WriteLine("Digite a placa do carro a ser verificada: ");
            string plate = Console.ReadLine(); 
            var plateVerifyResult = caso5.VerifyPlate(plate);
            Console.WriteLine(plateVerifyResult);
        
            Caso6 caso6 = new Caso6();
            Console.WriteLine("Selecione o formato da data: \n");
            Console.WriteLine("1 - Formato completo (dia da semana, dia do mês, mês, ano, hora, minutos, segundos) \n" +
                "2 - Apenas a data no formato '01/03/2024' \n" +
                "3 - Apenas a hora no formato de 24 horas \n" +
                "4 - A data com o mês por extenso.");
            string dateFormatSelected = Console.ReadLine();
            caso6.DateFormat(dateSelected: dateFormatSelected);


        }
    }
}