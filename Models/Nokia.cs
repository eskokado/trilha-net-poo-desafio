namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    public class Nokia : Smartphone
    {
        public Nokia(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria)
        {
        }
        // TODO: Sobrescrever o método "InstalarAplicativo"
        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalando o aplicativo {nomeApp} no Nokia {Modelo}.");
            Console.WriteLine($"Aplicativo {nomeApp} instalado com sucesso no Nokia {Modelo}.");
            Console.WriteLine($"O aplicativo {nomeApp} está pronto para uso no Nokia {Modelo}.");
        }
    }
}