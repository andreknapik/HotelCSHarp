using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HotelCSharp.Exceptions;
using HotelCSharp.Interfaces;

namespace HotelCSharp.Models
{
    public class RH : IRHTerceirizado

    {
        public string Nome {get;set;}
        public Hotel Hotel {get;set;}

        public RH(string nome, Hotel hotel)
        {
            Nome = nome;
            Hotel = hotel;

        }

        public void ContratarCamareira(ICamareira camareira)
        {
            Hotel.Camareiras.Add(camareira);
            
        }

        public void ContratarRecepcionista(IRecepcionista recepcionista)
        {
            Hotel.Recepcionistas.Add(recepcionista);
        }

        public void PromverParaGerente(Camareira camareira)
        {
            // UMa logica para entrevista
            if(camareira.CPF == null) 
            {
                throw new DocumentosInvalidosException("Regularize seu CPF para receber a promoção.");
            }

            Hotel.ContratarGerente(new Gerente(){
                Nome = camareira.Nome,
                CPF = camareira.CPF,
                Telefone = camareira.Telefone
        });
        
        }

        public void PromverParaGerente(Recepcionista recepcionista)
      {

            if(recepcionista.CPF == null) 
            {
                throw new DocumentosInvalidosException("Regularize seu CPF para receber a promoção.");
            }

            Hotel.ContratarGerente(new Gerente(){
                Nome = recepcionista.Nome,
                CPF = recepcionista.CPF,
                Telefone = recepcionista.Telefone
        });
        
        }
    }
}