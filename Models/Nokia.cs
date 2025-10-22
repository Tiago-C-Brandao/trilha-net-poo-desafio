namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    public class Nokia : Smartphone
    {
        public Nokia(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria) {}

        public override void InstalarAplicativo(string nomeApp)
        {
            if (nomeApp.EndsWith(".apk"))
            {
                Console.WriteLine($"\nInstalando o aplicativo {nomeApp} no android");
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
                Console.WriteLine($"\nDesinstalando o aplicativo {nomeApp} no android");
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