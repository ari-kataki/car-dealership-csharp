using CsharpApp.Models;
using CsharpApp.Services;

class Program
{
    static void Main()
    {
        AutomobileService service = new AutomobileService();


        service.AggiungiAutomobile(new Automobile("Ferrari", "F8 Tributo", 2023));
        service.AggiungiAutomobile(new Automobile("BMW", "M3", 2022));
        service.AggiungiAutomobile(new Automobile("Audi", "RS6", 2021));
        service.AggiungiAutomobile(new Automobile("Ferrari", "Roma", 2024));


        service.VisualizzaTutteAutomobili();


        service.AggiungiChilometri(0, 1500);
        service.AggiungiChilometri(1, 3200);


        Console.WriteLine("= RICERCA PER MARCA: Ferrari ");
        var ferraris = service.CercaPerMarca("Ferrari");
        foreach (var auto in ferraris)
        {
            Console.WriteLine($"→ {auto.Descrizione()}");
        }


        Console.WriteLine("\n STATO FINALE ");
        service.VisualizzaTutteAutomobili();

        Console.WriteLine($"Totale automobili nel sistema: {service.OttieniConteggio()}");
    }
}

