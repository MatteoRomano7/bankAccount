using System;

class ContoCorrente
{
    private bool contoAperto = false;
    private double saldo = 0;

    // Metodo per aprire il conto con un versamento iniziale
    public void ApriConto(double versamentoIniziale)
    {
        if (!contoAperto && versamentoIniziale >= 1000)
        {
            contoAperto = true;
            saldo += versamentoIniziale;
            Console.WriteLine("Conto aperto con successo.");
        }
        else
        {
            Console.WriteLine("Impossibile aprire il conto. Verifica il versamento iniziale.");
        }
    }

    // Metodo per effettuare un versamento
    public void Versamento(double importo)
    {
        if (contoAperto)
        {
            saldo += importo;
            Console.WriteLine($"Versamento di {importo} euro effettuato. Saldo attuale: {saldo} euro.");
        }
        else
        {
            Console.WriteLine("Conto non aperto. Impossibile effettuare il versamento.");
        }
    }

    // Metodo per effettuare un prelevamento
    public void Prelevamento(double importo)
    {
        if (contoAperto && saldo >= importo)
        {
            saldo -= importo;
            Console.WriteLine($"Prelevamento di {importo} euro effettuato. Saldo attuale: {saldo} euro.");
        }
        else
        {
            Console.WriteLine("Fondi insufficienti o conto non aperto. Impossibile effettuare il prelevamento.");
        }
    }
}

class Program
{
    static void Main()
    {
        // Test della classe ContoCorrente
        ContoCorrente conto = new ContoCorrente();
        conto.ApriConto(1200);
        conto.Versamento(500);
        conto.Prelevamento(300);

        // Algoritmo per la ricerca di un nome in un array di stringhe
        Console.WriteLine("\nInserisci la dimensione dell'array:");
        int dimensioneArray = int.Parse(Console.ReadLine());

        string[] nomi = new string[dimensioneArray];

        for (int i = 0; i < dimensioneArray; i++)
        {
            Console.WriteLine($"Inserisci il nome {i + 1}:");
            nomi[i] = Console.ReadLine();
        }

        Console.WriteLine("Inserisci il nome da cercare:");
        string nomeDaCercare = Console.ReadLine();

        bool nomePresente = Array.Exists(nomi, nome => nome == nomeDaCercare);
        Console.WriteLine($"Il nome '{nomeDaCercare}' {(nomePresente ? "è" : "non è")} presente nell'array.");

        // Algoritmo per la somma e la media di un array di numeri interi
        Console.WriteLine("\nInserisci la dimensione dell'array di numeri:");
        dimensioneArray = int.Parse(Console.ReadLine());

        int[] numeri = new int[dimensioneArray];

        for (int i = 0; i < dimensioneArray; i++)
        {
            Console.WriteLine($"Inserisci il numero {i + 1}:");
            numeri[i] = int.Parse(Console.ReadLine());
        }

        int somma = 0;

        foreach (var numero in numeri)
        {
            somma += numero;
        }

        double media = (double)somma / dimensioneArray;

        Console.WriteLine($"La somma di tutti i numeri è: {somma}");
        Console.WriteLine($"La media aritmetica di tutti i numeri è: {media}");
    }
}
