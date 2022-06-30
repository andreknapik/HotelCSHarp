
using HotelCSharp.Models;

Console.WriteLine("*******************************************");
Console.WriteLine("************** Hotel  CSharp **************");
Console.WriteLine("*******************************************");
Console.WriteLine();

// Contratar uma camareira.

var camareira = new Camareira("Joana Prado", "12345678902","21-977886655");
camareira.SeApresentar();
camareira.ArrumarACama();
camareira.LimparOQuarto();


var recepcionista = new Recepcionista()
{
    Nome ="Mariana Prado",
    CPF =  "02345678901",
    Telefone = "21-977886677",
};

recepcionista.SeApresentar();
recepcionista.AtenderTelefone();
recepcionista.FalarIngles();