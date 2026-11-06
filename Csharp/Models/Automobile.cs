// Commento di confronto tra OOP e programmazione procedurale:
// OOP: Incapsula i dati (proprietà) e i comportamenti (metodi) dentro oggetti
// Programmazione procedurale: Separa i dati dalle funzioni che li manipolano
// OOP è più mantenibile perché i dati sono protetti e coesi con la loro logica
// La classe Automobile è un esempio di OOP: raggruppa proprietà e metodi correlati
// Questo approccio facilita il riuso e l'estensibilità del codice

namespace CsharpApp.Models
{
    public class Automobile
    {
        private int _chilometri;

        public Automobile()
        {
            Marca = "";
            Modello = "";
            _chilometri = 0;
        }

        public Automobile(string marca, string modello, int anno)
        {
            Marca = marca;
            Modello = modello;
            Anno = anno;
            _chilometri = 0;
        }

        public string Marca { get; set; }

        public string Modello { get; set; }

        public int Anno { get; set; }

        public int Chilometri
        {
            get { return _chilometri; }
        }

        public string Descrizione()
        {
            return $"Automobile: Marca --> {Marca} | Modello --> {Modello} | Anno --> {Anno} | Chilometri --> {_chilometri}";
        }

        public void AggiungiChilometri(int km)
        {
            if (km > 0)
            {
                _chilometri += km;
            }
        }
    }
}
