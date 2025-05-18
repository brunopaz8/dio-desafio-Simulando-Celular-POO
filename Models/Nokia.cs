namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    public class Nokia : Smartphone
    {
        public Nokia(string Numero, string Modelo, string IMEI, int Memoria) : base(Numero, Modelo, IMEI, Memoria)
        {

        }
        public override void InstalarAplicativo(string nomeApp, int tamanhoApp)
        {
            if (tamanhoApp > Memoria)
            {
                Console.WriteLine($"Não há espaço o suficiente no Nokia, faltando {Memoria - tamanhoApp} gb!");
            }
            else
            {
                Aplicativos.Add(nomeApp);
                Console.WriteLine($"Aplicativo: {nomeApp} instalado no Nokia!");
            }
        }
        
        public override void MostrandoAplicativos()
        {
            if (Aplicativos.Count > 0)
            {
                Console.WriteLine("=== Aplicativos Baixados no Nokia ===");
                foreach (string app in Aplicativos)
                {
                    Console.WriteLine($"{Aplicativos.IndexOf(app) + 1} - {app}");
                }
                Console.WriteLine("=====================================");
            }
            else
            {
                Console.WriteLine("Ainda não há app instalados no Nokia!");
            }
        }
    }
}