namespace PRJorientacaoObjetos.ClasseBase
{
    public class Pedido
    {
        public int Qtd { get; private set; }
        public string Nome { get; private set;}
        public string Endereco { get; private set; }


        public void Dados (int qtd, string nome, string endereco)
        {
            this.Qtd = qtd;
            this.Nome = nome;
            this.Endereco = endereco;
        }  
        public void Situacao()
        {
            Console.WriteLine("O pedido está em andamento!");
        }
    }
}