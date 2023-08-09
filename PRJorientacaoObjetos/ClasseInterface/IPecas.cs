namespace PRJorientacaoObjetos.ClasseBase
{
    public interface IPecas
    {
         public void Montar (string placaMae, string placaDeVideo,  int qtdMemoria, int ssd, string fonte, string sistemaOP);

         public void MostrarConfig ();
    }
}