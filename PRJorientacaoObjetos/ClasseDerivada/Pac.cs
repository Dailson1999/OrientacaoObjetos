using PRJorientacaoObjetos.ClasseAbstrata;

namespace PRJorientacaoObjetos.ClasseDerivada
{
    public class Pac : Entrega
    {
        public string MeioDeTransporte { get; private set; }
        public override void Entregar(string MeioDeTransporte)
        {
            this.MeioDeTransporte = MeioDeTransporte;
        }
        public override void Update()
        {
            System.Console.WriteLine("O pacote está nos correios enviado por Pac!");
        }

    }
}