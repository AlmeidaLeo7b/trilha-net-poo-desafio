namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    public class Iphone :Smartphone
    {
       
        public Iphone(string numero, string modelo, int memoria, string imei)
            : base(numero, modelo, memoria, imei)
        {
        }

        public override void InstalarAplicativo(string nome)
        {
            // Lógica específica da Nokia para instalar aplicativos
            Console.WriteLine($"Instalando aplicativo {nome} no Iphone");
        }
    }
}