namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    public class Nokia:Smartphone
    {
        // TODO: Sobrescrever o método "InstalarAplicativo"
        override
        public void InstalarAplicativo(string nome)
        {
            Console.WriteLine($" Instalando o {nome} no Nokia...");
        }
    }
}