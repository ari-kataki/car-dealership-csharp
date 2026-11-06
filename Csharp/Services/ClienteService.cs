using CsharpApp.Models;

namespace CsharpApp.Services
{
    /// <summary>
    /// ClienteService API - Gestisce le operazioni sugli oggetti Cliente
    /// </summary>
    public class ClienteService
    {
        private List<Cliente> clienti = new List<Cliente>();

        /// <summary>
        /// Aggiunge un nuovo cliente al servizio
        /// </summary>
        public void AggiungiCliente(Cliente cliente)
        {
            if (cliente != null)
            {
                clienti.Add(cliente);
                Console.WriteLine($"✓ Cliente aggiunto: {cliente.Nome}");
            }
        }

        /// <summary>
        /// Ritorna tutti i clienti registrati
        /// </summary>
        public List<Cliente> OttieniTuttiClienti()
        {
            return clienti;
        }

        /// <summary>
        /// Visualizza i dettagli di tutti i clienti
        /// </summary>
        public void VisualizzaTuttiClienti()
        {
            if (clienti.Count == 0)
            {
                Console.WriteLine("Nessun cliente registrato.");
                return;
            }

            Console.WriteLine("\n========== ELENCO CLIENTI ==========");
            for (int i = 0; i < clienti.Count; i++)
            {
                Console.WriteLine($"\n[{i + 1}] {clienti[i].Descrizione()}");
            }
            Console.WriteLine("====================================\n");
        }

        /// <summary>
        /// Cerca cliente per nome
        /// </summary>
        public Cliente? CercaPerNome(string nome)
        {
            return clienti.FirstOrDefault(c => c.Nome.ToLower() == nome.ToLower());
        }

        /// <summary>
        /// Cerca cliente per email
        /// </summary>
        public Cliente? CercaPerEmail(string email)
        {
            return clienti.FirstOrDefault(c => c.Email.ToLower() == email.ToLower());
        }

        /// <summary>
        /// Ottiene il numero totale di clienti
        /// </summary>
        public int OttieniConteggio()
        {
            return clienti.Count;
        }

        /// <summary>
        /// Elimina un cliente per nome
        /// </summary>
        public bool EliminaCliente(string nome)
        {
            var cliente = CercaPerNome(nome);
            if (cliente != null)
            {
                clienti.Remove(cliente);
                Console.WriteLine($"✓ Cliente eliminato: {nome}");
                return true;
            }
            Console.WriteLine($"✗ Cliente non trovato: {nome}");
            return false;
        }
    }
}
