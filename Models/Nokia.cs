public class Nokia : Smartphone
{
    // Construtor chamando o construtor da classe base
    public Nokia(string numero) : base(numero)
    {
        // TODO: Implemente conforme necessário
    }

    // Sobrescrever o método InstalarAplicativo
    public override void InstalarAplicativo(string nomeAplicativo)
    {
        Console.WriteLine($"Instalando {nomeAplicativo} na loja de aplicativos da Nokia.");
        // TODO: Implemente conforme necessário
    }
}