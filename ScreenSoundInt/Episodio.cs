class Episodio
{
    public Episodio(int ordem, string titulo, int duracao)
    {
        Ordem = ordem;
        Titulo = titulo;
        Duracao = duracao;
    }

    private List<string> convidados = new();
    public int Duracao { get; }
    public int Ordem { get; }
    public string Resumo => $"{Ordem}. {Titulo} ({Duracao} min) - {string.Join(",", convidados)}";
    public string Titulo { get; }

    public void AdicionarConvidados(string convidado)
    {
        convidados.Add(convidado);
    }
}