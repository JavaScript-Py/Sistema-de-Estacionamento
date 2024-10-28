namespace Preco;
public class Preco
{
  public int PrecoBase { get; set; }
  public int PrecoHora { get; set; }
  static void EscreverErro()
  {
    Console.Clear();
    Console.WriteLine("Preço inválido");
    Console.WriteLine("Digite o valor: ");
  }
  public int validarPreco(string? precoInicial)
  {
    int preco;
    while (true)
    {
      if (!int.TryParse(precoInicial, out int result))
      {
        EscreverErro();
        precoInicial = Console.ReadLine();
      }
      else
      {
        preco = Convert.ToInt32(precoInicial);
        if (preco <= 0)
        {
          EscreverErro();
          precoInicial = Console.ReadLine();
        }
        else
        {
          break;
        }
      }
    }
    return preco;
  }
}