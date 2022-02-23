using CsvHelper.Configuration.Attributes;
public class Livro{
    //[Index(0)]
    //[Name("titulo")]
    public string Titulo { get; set;}
    //[Name("autor")]
    //[Index(2)]
    public string Autor { get; set;}
    //[Name("preço")]
    //[Index(1)]
    //[CultureInfo("pt-BR")]
    public decimal Preco { get; set;}
    //[Name("lancamento")]
    //[Index(3)]
    //[Format("dd/mm/yyyy")]
    public string Lancamento { get; set;}

}