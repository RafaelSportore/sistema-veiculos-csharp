public class Carro : Veiculo
{
    public int NumeroPortas{get;set;}

    public override void ExibirDados()
{
    base.ExibirDados();
    Console.WriteLine($"Portas: {NumeroPortas}");
}
    
    public override double CalcularPrecoVeiculo()
    {
        PrecoFinal = PrecoBase * 1.10;
        return PrecoFinal;
    }
}