namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    public class Iphone : Smartphone
    {
        public Iphone(string Numero, string Modelo, string IMEI, int Memoria) : base(Numero, Modelo, IMEI, Memoria)
        {

        }

        public override void InstalarAplicativo(string nomeApp, int tamanhoApp)
        {
            if (tamanhoApp > Memoria)
            {
                Console.WriteLine($"Não há espaço o suficiente no Iphone, faltando {Memoria - tamanhoApp} gb!");
            }
            else
            {
                Aplicativos.Add(nomeApp);
                Memoria -= tamanhoApp;
                Console.WriteLine($"Aplicativo: {nomeApp} instalado no Iphone!");
                Console.WriteLine($"Memória sobrando: {Memoria} gb.");
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
                Console.WriteLine("Ainda não há app instalados no Iphone!");
            }
        }
    }
}