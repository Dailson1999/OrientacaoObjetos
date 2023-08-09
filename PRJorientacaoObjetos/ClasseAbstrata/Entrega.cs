namespace PRJorientacaoObjetos.ClasseAbstrata
{
    public abstract class Entrega
    {
        public string ID { get; set; }

        public abstract void Entregar(string meioDeTransporte);
        public virtual void Update()
        {
            System.Console.WriteLine("O pacote está nos correios!");
        }
    }
}