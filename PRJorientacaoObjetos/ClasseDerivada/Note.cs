using PRJorientacaoObjetos.ClasseBase;

namespace PRJorientacaoObjetos.ClasseDerivada
{
    public class Note : IPecas
    {
        public string PlacaMae { get; private set; }
        public string PlacaDeVideo { get; private set; }
        public int QtdMemoria { get; private set; }
        public int SSD { get; private set; }
        public  string Fonte { get; private set; }
        public string SistemaOP { get; private set; }
        public int Tela { get; private set; }
        public string Teclado { get; private set; }
        public int Webcam { get; private set; }

        public void Montar(string placaMae, string placaDeVideo,  int qtdMemoria, int ssd, string fonte, string sistemaOP)
        {
            this.PlacaMae = placaMae;
            this.PlacaDeVideo = placaDeVideo;
            this.QtdMemoria = QtdMemoria + qtdMemoria;
            this.SSD = SSD + ssd;
            this.Fonte = fonte;
            this.SistemaOP = sistemaOP;
        }
        public void Perifericos (int tela, string teclado, int webcam)
        {
            this.Tela = tela;
            this.Teclado = teclado;
            this.Webcam = webcam;
        }

        public void MostrarConfig()
        {
            Console.WriteLine($"O notebook tem as seguintes configuração. \r\n Placa mãe: {PlacaMae} \r\n Placa de Vídeo: {PlacaDeVideo} \r\n Memoria ram: {QtdMemoria} \r\n SSD: {SSD} \r\n Fonte: {Fonte} \r\n Sistema Operacional: {SistemaOP}");
        }

    }
}