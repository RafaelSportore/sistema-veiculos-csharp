public class Veiculo
{
    public string CodigoVeiculo{get;set;}
    public string Marca{get;set;}
    public string Modelo{get;set;}
    public int Ano{get;set;}
    public double PrecoBase{get;set;}
    public double PrecoFinal{get;set;}

    public virtual void ExibirDados()
{
    Console.WriteLine($"Codigo: {CodigoVeiculo}");
    Console.WriteLine($"Marca: {Marca}");
    Console.WriteLine($"Modelo: {Modelo}");
    Console.WriteLine($"Ano: {Ano}");
    Console.WriteLine($"Preço Base: {PrecoBase}");
}

    public virtual double CalcularPrecoVeiculo()
    {
        return PrecoFinal;
    }
}