namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    public class Iphone : Smartphone
    {
        public Iphone(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria) { }
        
        public override void InstalarAplicativo(string nomeApp)
        {
            if(nomeApp.EndsWith(".ipa"))
            {
                Console.WriteLine($"\nInstalando o aplicativo {nomeApp} no ios");
                Aplicativos.Add(nomeApp);
                Console.WriteLine($"{nomeApp} instalado com sucesso!");
            }
            else
            {
                throw new Exception("Formato não suportado pelo sistema");
            }
        }

        public override void DesinstalarAplicativo(string nomeApp)
        {
            bool validandoApp = Aplicativos.Contains(nomeApp);
            if (validandoApp)
            {
                Console.WriteLine($"\nDesinstalando o aplicativo {nomeApp} no ios");
                Aplicativos.Remove(nomeApp);
                Console.WriteLine($"{nomeApp} desinstalado com sucesso!");
            }
            else
            {
                Console.WriteLine($"\n{nomeApp} não encontrado.");
            }
        }
    }
}