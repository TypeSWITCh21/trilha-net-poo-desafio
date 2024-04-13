namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    // DONE
    public class Nokia : Smartphone
    {

        public Nokia(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria)
        {
        }
        
            // TODO: Sobrescrever o método "InstalarAplicativo"
            // DONE
        public override void InstalarAplicativo(String NomeApp)
            {
                Console.WriteLine($"O Nokia está instalando o aplicativo {NomeApp}..." + "aguarde");
            }
        

    }
}