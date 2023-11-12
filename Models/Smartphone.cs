using System;

// Classe abstrata Smartphone
public abstract class Smartphone
{
    public string Numero { get; set; }

    // Método abstrato a ser implementado nas classes filhas
    public abstract void InstalarAplicativo(string nomeAplicativo);

    // Construtor
    public Smartphone(string numero)
    {
        Numero = numero;
    }
}

