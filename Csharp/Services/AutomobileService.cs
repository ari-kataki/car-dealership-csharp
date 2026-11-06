using CsharpApp.Models;

namespace CsharpApp.Services
{

    public class AutomobileService
    {
        private List<Automobile> automobili = new List<Automobile>();


        public void AggiungiAutomobile(Automobile auto)
        {
            if (auto != null)
            {
                automobili.Add(auto);
                Console.WriteLine($"✓ Automobile aggiunta: {auto.Marca} {auto.Modello}");
            }
        }


        public List<Automobile> OttieniTutteAutomobili()
        {
            return automobili;
        }

        public void VisualizzaTutteAutomobili()
        {
            if (automobili.Count == 0)
            {
                Console.WriteLine("Nessuna automobile registrata.");
                return;
            }

            Console.WriteLine("\n== ELENCO AUTOMOBILI ==");
            for (int i = 0; i < automobili.Count; i++)
            {
                Console.WriteLine($"\n[{i + 1}] {automobili[i].Descrizione()}");
            }
            Console.WriteLine("======\n");
        }


        public List<Automobile> CercaPerMarca(string marca)
        {
            return automobili.Where(a => a.Marca.ToLower() == marca.ToLower()).ToList();
        }

        public List<Automobile> CercaPerAnno(int anno)
        {
            return automobili.Where(a => a.Anno == anno).ToList();
        }


        public void AggiungiChilometri(int indice, int km)
        {
            if (indice >= 0 && indice < automobili.Count)
            {
                automobili[indice].AggiungiChilometri(km);
                Console.WriteLine($"✓ Chilometri aggiornati per {automobili[indice].Marca} {automobili[indice].Modello}");
            }
            else
            {
                Console.WriteLine("✗ Automobile non trovata.");
            }
        }


        public int OttieniConteggio()
        {
            return automobili.Count;
        }
    }
}
