using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelCSharp.Interfaces 
{
    public interface IRecepcionista : IPessoa
    {
        public void AtenderTelefone();
        public void FalarIngles();
    }
}