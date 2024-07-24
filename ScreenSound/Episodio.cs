class Episodio
{
    public int Duracao { get; }
    public int Ordem { get; }
    public string Resumo { get; set; }
    public string Titulo { get; set; }

    public Episodio(int ordem, string resumo, string titulo)
    {
        Ordem = ordem;
        Resumo = resumo;
        Titulo = titulo;
    }


}
