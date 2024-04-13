namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    // DONE
    public class Iphone : Smartphone
    {
        public Iphone(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria)
        {
        }

        
             // TODO: Sobrescrever o método "InstalarAplicativo"
            // DONE
        public override void InstalarAplicativo(String NomeApp)
            {
                Console.WriteLine($"O Iphone esta Fazendo o download do app {NomeApp}, aguarde.");
            }
        
    }
}