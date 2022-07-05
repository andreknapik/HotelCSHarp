using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelCSharp.Exceptions
{
    public class DocumentosInvalidosException : Exception
    {
        public DocumentosInvalidosException()
        :base("Docmumentos Inválidos, verifique!")
        {
            
        }

        public  DocumentosInvalidosException(string mensagem) : base(mensagem)
        {
            
        }
    }
}