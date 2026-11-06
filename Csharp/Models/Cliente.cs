namespace CsharpApp.Models
{
    public class Cliente
    {
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Telefono { get; set; }

        public Cliente()
        {
            Nome = "";
            Email = "";
            Telefono = "";
        }

        public Cliente(string nome, string email, string telefono)
        {
            Nome = nome;
            Email = email;
            Telefono = telefono;
        }

        public string Descrizione()
        {
            return $"Cliente: Nome --> {Nome} | Email --> {Email} | Telefono --> {Telefono}";
        }
    }
}
