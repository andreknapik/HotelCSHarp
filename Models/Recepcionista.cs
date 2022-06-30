using HotelCSharp.Interfaces;

namespace HotelCSharp.Models
{
    public class Recepcionista : Pessoa, IRecepcionista
    {
        public Recepcionista() : base()
        {   
        }
        public Recepcionista(string nome, string cpf, string telefone) 
        : base(nome, cpf, telefone)
        {
        }

        public void AtenderTelefone()
        {
            Console.WriteLine("Sei atender o telefone.");
            Console.WriteLine();
        }

        public void FalarIngles()
        {
            Console.WriteLine("Sei falar o básico de Inglês");
            Console.WriteLine();
        }

        public override void SeApresentar()
        {
            Console.WriteLine("Prazer sou a recepcionista " + Nome);
            Console.WriteLine();
        }
    }
}