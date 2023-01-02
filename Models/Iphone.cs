namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    public class Iphone:Smartphone
    {
        // TODO: Sobrescrever o método "InstalarAplicativo"
        override
        public void InstalarAplicativo(string nome)
        {
             Console.WriteLine($" Instalando o {nome} no Iphone...");
        }
    }
}