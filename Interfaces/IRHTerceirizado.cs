using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HotelCSharp.Models;

namespace HotelCSharp.Interfaces
{
    public interface IRHTerceirizado
    {
        void ContratarCamareira(ICamareira camareira);
        void ContratarRecepcionista(IRecepcionista recepcionista);
        void PromverParaGerente(Camareira camareira);
        void PromverParaGerente(Recepcionista recepcionista);
    }
}