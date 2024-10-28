using View;
using Preco;

public class SistemaDeEstacionamento
{
  Preco.Preco p = new();
  public static void Main()
  {
    Preco.Preco p = new();
    SistemaDeEstacionamento sistema = new();
    sistema.IniciarSistema();
  }
  void ReceberPreco()
  {
    Console.WriteLine("Digite o preço inicial: ");
    string? precoBaseInicial = Console.ReadLine();
    p.PrecoBase = p.validarPreco(precoBaseInicial);

    Console.WriteLine("Digite o preço por hora: ");
    string? precoHoraInicial = Console.ReadLine();
    p.PrecoHora = p.validarPreco(precoHoraInicial);
  }
  public void IniciarSistema()
  {
    ReceberPreco();
    Menu menu = new();
    menu.ShowMenu(p);
  }
}