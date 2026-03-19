using System.ComponentModel;
using System.ComponentModel.Design;

List<Veiculo> veiculo = new List<Veiculo>();

bool sairMenu = false;
string sair;

do
{

    Console.WriteLine("===== MENU =====");
    Console.WriteLine("1 - Cadastrar Carro");
    Console.WriteLine("2 - Cadastrar Moto");
    Console.WriteLine("3 - Listar veiculo");
    Console.WriteLine("4 - Calcular preço final");
    Console.WriteLine("5 - Sair");

    Console.WriteLine("Selecione uma opção:");
    int opcao;

    if (!int.TryParse(Console.ReadLine(), out opcao))
    {
        Console.WriteLine("Entrada inválida!");
        continue;
    }
    
    switch (opcao)
    {



        case 1:

            do
            {

                Console.WriteLine("====== Cadastar Carro ======\n");

                Carro c = new Carro();

                Console.WriteLine("Insira o Codigo do Veiculo:");
                c.CodigoVeiculo = Console.ReadLine().ToLower();

                Console.WriteLine("Insira a Marca do veiculo:");
                c.Marca = Console.ReadLine().ToLower();

                Console.WriteLine("Insira o Modelo do veiculo:");
                c.Modelo = Console.ReadLine().ToLower();

                Console.WriteLine("Insira o Ano de fabricação do veiculo:");
                c.Ano = int.Parse(Console.ReadLine().ToLower());

                Console.WriteLine("Insira o Numero de Portas do veiculo:");
                c.NumeroPortas = int.Parse(Console.ReadLine().ToLower());

                Console.WriteLine("Insira o Preço Base:");
                c.PrecoBase = double.Parse(Console.ReadLine().ToLower());

                veiculo.Add(c);

                Console.WriteLine("Deseja cadastrar outro Carro? (s/n)");
                sair = Console.ReadLine().ToLower();

                Console.WriteLine("============================\n");

            } while (sair == "s");



            break;

        case 2:

            do
            {

                Console.WriteLine("====== Cadastar Moto ======\n");

                Moto m = new Moto();

                Console.WriteLine("Insira o Codigo do Veiculo:");
                m.CodigoVeiculo = Console.ReadLine().ToLower();

                Console.WriteLine("Insira a Marca do veiculo:");
                m.Marca = Console.ReadLine().ToLower();

                Console.WriteLine("Insira o Modelo do veiculo:");
                m.Modelo = Console.ReadLine().ToLower();

                Console.WriteLine("Insira o Ano de fabricação do veiculo:");
                m.Ano = int.Parse(Console.ReadLine().ToLower());

                Console.WriteLine("Insira a Cilindrada do veiculo:");
                m.Cilindrada = int.Parse(Console.ReadLine().ToLower());

                Console.WriteLine("Insira o Tipo de Partida do veiculo:");
                m.TipoPartida = Console.ReadLine().ToLower();

                Console.WriteLine("Insira o Preço Base:");
                m.PrecoBase = double.Parse(Console.ReadLine().ToLower());

                veiculo.Add(m);

                Console.WriteLine("Deseja cadastrar outra Moto? (s/n)");
                sair = Console.ReadLine().ToLower();

                Console.WriteLine("===========================\n");

            } while (sair == "s");

            break;

        case 3:

            Console.WriteLine("====== Lista De Veiculos ======\n");

            foreach (var v in veiculo)
            {

                v.ExibirDados();
                Console.WriteLine();
            }

            Console.WriteLine("===============================\n");

            break;

        case 4:

            do
            {

                string veiculoDesejado;
                int encontrado = 0;

                Console.WriteLine("====== Calcular Preço Final ======\n");

                Console.WriteLine("Digite o Codigo do veiculo desejado:");
                veiculoDesejado = Console.ReadLine().ToLower();

                foreach (Veiculo vei in veiculo)
                {
                    if (vei.CodigoVeiculo == veiculoDesejado)
                    {
                        double pFinal = vei.CalcularPrecoVeiculo();
                        Console.WriteLine($"O preço final do {vei.Modelo} é: {pFinal}");
                        encontrado = 1;
                    }

                }

                if (encontrado != 1)
                {
                    Console.WriteLine("Veiculo não encontrado");
                }



                Console.WriteLine("Deseja pesquisar outro Veiculo? (s/n)");
                sair = Console.ReadLine().ToLower();

                Console.WriteLine("==================================\n");

            } while (sair == "s");

            break;

        case 5:

            Console.WriteLine("Tchau!!!");
            sairMenu = true;

            break;

        default:
            break;
    }



} while (sairMenu != true);