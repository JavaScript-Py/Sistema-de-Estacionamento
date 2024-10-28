namespace View
{
  using Models;
  using Preco;
  public class Menu
  {
    static void LimparTela()
    {
      Console.WriteLine("Digite qualquer tecla para continuar...");
      Console.ReadKey();
      Console.Clear();
    }
    public void ShowMenu(Preco preco)
    {
      Models Models = new(preco);
      int n = 0;
      while (n != 4)
      {
        Console.WriteLine("1. Cadastrar Veiculo");
        Console.WriteLine("2. Remover veiculo");
        Console.WriteLine("3. Listar veiculo(s)");
        Console.WriteLine("4. Sair");
        n = Convert.ToInt32(Console.ReadLine());
        switch (n)
        {
          case 1:
            Console.WriteLine("Digite a placa do veiculo");
            string? placa = Console.ReadLine();
            if (string.IsNullOrEmpty(placa))
            {
              Console.WriteLine("Placa inválida");
            }
            else
            {
              Models.CadastrarVeiculo(placa);
            }
            LimparTela();
            break;
          case 2:
            Console.WriteLine("Digite a placa do veiculo que deseja remover");
            string? veiculoParaRemover = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(veiculoParaRemover))
            {
              Console.WriteLine("Placa inválida");
            }
            else
            {
              Models.RemoverVeiculo(veiculoParaRemover);
            }
            LimparTela();
            break;
          case 3:
            Models.listarVeiculos();
            LimparTela();
            break;
          case 4:
            Console.Clear();
            Environment.Exit(0);
            break;
          default:
            Console.WriteLine("Opção inválida");
            Console.Clear();
            break;
        }
      }
    }
  }
}