// Classe Iphone herdando de Smartphone
public class Iphone : Smartphone
{
    // Construtor chamando o construtor da classe base
    public Iphone(string numero) : base(numero)
    {
        // TODO: Implemente conforme necessário
    }

    // Sobrescrever o método InstalarAplicativo
    public override void InstalarAplicativo(string nomeAplicativo)
    {
        Console.WriteLine($"Instalando {nomeAplicativo} na App Store da Apple.");
        // TODO: Implemente conforme necessário
    }
}
