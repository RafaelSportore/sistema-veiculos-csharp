public class Moto : Veiculo
{
    public int Cilindrada {get;set;}
    public string TipoPartida {get;set;}

    public override void ExibirDados()
{
    base.ExibirDados();
    Console.WriteLine($"Cilindrada: {Cilindrada}");
    Console.WriteLine($"Partida: {TipoPartida}");
}

    public override double CalcularPrecoVeiculo()
    {
        PrecoFinal = PrecoBase * 1.05;
        return PrecoFinal;
    }
}