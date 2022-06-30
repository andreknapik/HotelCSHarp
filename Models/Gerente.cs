using HotelCSharp.Interfaces;

namespace HotelCSharp.Models
{
    public class Gerente : Pessoa, IGerente
    {
        public Gerente() : base()
        {   
        }
        public Gerente(string nome, string cpf, string telefone) 
        : base(nome, cpf, telefone)
        {
        }

        public void ArrumarACama()
        {
            Console.WriteLine("Sou gerente e sei aarrumar a Cama.");
            Console.WriteLine();
        }

        public void AtenderTelefone()
        {
            Console.WriteLine("Sou gerente e sei atender o telefone.");
            Console.WriteLine();
        }

        public void ConhecerMuitoBemOHotel()
        {
            Console.WriteLine("Sou gerente e conheço tudo do Hotel.");
            Console.WriteLine();
        }

        public void FalarIngles()
        {
            Console.WriteLine("Sou gerente e domino o Inglês.");
            Console.WriteLine();
        }

        public void LimparOQuarto()
        {
            Console.WriteLine("Sou gerente e sei limpar o quarto.");
            Console.WriteLine();
        }

        public override void SeApresentar()
        {
            Console.WriteLine("Prazer, sou Gerente e meu nome é "+ Nome);
            Console.WriteLine();
        }
    }
}