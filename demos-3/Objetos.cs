public ref struct Pessoa{
    public int Idade { get; set; }
    public string Nome { get; set; }
    public Endereco endereco { get; set; }
}

public /*ref*/ struct Endereco : Dados{
    public int Numero { get; set; }
    public string Logradouro { get; set; }
    public string CEP { get; set; }
    public string Cidade { get; set; }

    // Span<int> num { get; set; }

}

public interface Dados{
    int Numero { get; set;}
}