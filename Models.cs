namespace Models
{
  using Preco;
  public class Models(Preco preco)
  {
    List<string> veiculos = [];
    Preco Preco = preco;
    public void CadastrarVeiculo(string veiculo)
    {
      veiculos.Add(veiculo);
      Console.Clear();
      Console.WriteLine($"Veiculo {veiculo} cadastrado com sucesso");
    }
    public void RemoverVeiculo(string veiculo)
    {
      if (veiculos.Contains(veiculo))
      {
        Console.WriteLine("Digite a quantidade de horas que o veiculo ficou estacionado");
        int horasEstacionado = Preco.validarPreco(Console.ReadLine());
        Console.WriteLine($"Valor do estacionamento: {Preco.PrecoBase + Preco.PrecoHora * horasEstacionado}");
        veiculos.Remove(veiculo);
        Console.WriteLine($"Veiculo {veiculo} removido com sucesso");
      }
      else
      {
        Console.WriteLine($"Veiculo {veiculo} não encontrado ou inválido");
      }
    }
    public void listarVeiculos()
    {
      if (veiculos.Count == 0)
      {
        Console.WriteLine("Nenhum veiculo cadastrado");
      }
      else
      {
        Console.Clear();
        Console.WriteLine("Veiculos cadastrados:");
        foreach (var veiculo in veiculos)
        {
          Console.WriteLine(veiculo);
        }
      }
    }
  }
}