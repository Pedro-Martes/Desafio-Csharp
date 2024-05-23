namespace Desafio.Casos;

public class Caso5 {
    public string VerifyPlate(string plate) {
        

        string response;

        char[] stringArray = plate.ToCharArray();
        int arraySize = stringArray.Count();

        if(arraySize < 7  || arraySize > 7) {
            response = "A placa fornecida não é valida! A placa não tem 7 caracteres alfanuméricos.";
            return response;

        }
        for(int i = 0; i < 3; i++) {
            string caracter = stringArray[i].ToString();


            if(double.TryParse(caracter,out double result)) {
                response = " A placa fornecida não é valida! Os três primeiros caracteres não são letras";
                return response;
            }
        }


        string lastFourNumbers = string.Join("",stringArray.Skip(arraySize - 4));
        
        if(!double.TryParse(lastFourNumbers,out double result2)){
            response = " A placa fornecida não é valida! Os quatro últimos caracteres não são números";
            return response;
        }


        return response = "Placa valida com sucesso!";
    }
}
