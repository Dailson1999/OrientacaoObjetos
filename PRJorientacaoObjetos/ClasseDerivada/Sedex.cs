using PRJorientacaoObjetos.ClasseAbstrata;

namespace PRJorientacaoObjetos.ClasseDerivada
{
    public class Sedex : Entrega
    {
        public string MeioDeTransport { get; private set; }
        public override void Entregar(string meioDeTransporte)
        {
            this.MeioDeTransport = meioDeTransporte;
        }

        public override void Update()
        {
            System.Console.WriteLine("O pacote está nos correios enviado por sedex!");
        }

    }
}