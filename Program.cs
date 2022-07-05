
using HotelCSharp.Interfaces;
using HotelCSharp.Models;

Console.WriteLine("*******************************************");
Console.WriteLine("************** Hotel  CSharp **************");
Console.WriteLine("*******************************************");
Console.WriteLine();

// Contratar uma camareira.

ICamareira camareira1 = new Camareira("Joana Prado", "12345678902","21-977886655");
ICamareira camareira2 = new Camareira("Maria Prado", "12345678902","21-977886656");


IRecepcionista recepcionista1 = new Recepcionista()
{
    Nome ="Mariana Prado",
    CPF =  "02345678901",
    Telefone = "21-977886677",
};

IRecepcionista recepcionista2 = new Recepcionista()
{
    Nome ="Jessica Albuquerque",
    CPF =  "02345678901",
    Telefone = "21-977886687",
};


// Administrou 10 hotéis e é o cara da gerência. Trabalhando atualmente.
IGerente gerente1 = new Gerente()
{
    Nome ="André Xrep",
    CPF =  "02345678954",
    Telefone = "21-977886699",
};

// Administrou 2 hotéis e está desempregado.
IGerente gerente2 = new Gerente()
{
    Nome ="Ciclano de Tal",
    CPF =  "02345678954",
    Telefone = "21-977886799",
};

// Inaugurando o Hotel

Hotel hotel = new Hotel("Hotel Csharp", new Endereco()
{
    CEP = "25985630", 
    Rua = "Rua  XYZ",
    Numero = 58,
    Complemento = "Esquina 3",
    Bairro = "Lugar Nenhum",
    Cidade = "Qualquer Lugar",
});

// Contratando 2 Camareiras
hotel.ContratarCamareira(camareira1);
hotel.ContratarCamareira(camareira2);

// Contratando 2 Recepcionistas
hotel.ContratarRecepcionista(recepcionista1);
hotel.ContratarRecepcionista(recepcionista2);

// Contratando o gerente;
hotel.ContratarGerente(gerente1);

// Contratar o Faz Tudo.
hotel.ContratarCamareira(gerente2);
hotel.ContratarRecepcionista(gerente2);

// Gerente. 
hotel.Gerente.SeApresentar();
hotel.Gerente.ArrumarACama();
hotel.Gerente.LimparOQuarto();
hotel.Gerente.AtenderTelefone();
hotel.Gerente.FalarIngles();

foreach (var camareira in hotel.Camareiras)
{
    camareira.SeApresentar();
    camareira.ArrumarACama();
    camareira.LimparOQuarto();
}

foreach (var recepcionista in hotel.Recepcionistas)
{
    recepcionista.SeApresentar();
    recepcionista.AtenderTelefone();
    recepcionista.FalarIngles();
}


// Daqui pra baixo será tudo por conta do RH rsrsrs

IRHTerceirizado rh = new RH("RH Csharp", hotel);

// Contratar uma Camareira
var camareira3 = new Camareira{
    Nome = "Eugenia Ferraz"
};
rh.ContratarCamareira(camareira3);
// Contratar uma Recepcionista

var recepcionista3 = new Recepcionista{
    Nome = "Joice Lima",
    CPF = "1234567898",
    Telefone = "41997099911"
};
rh.ContratarRecepcionista(recepcionista3);

// Promover uma Camareira
var CamareiraASerPromovida = new Camareira{
    Nome = "Eugenia Lima"
};
rh.PromverParaGerente(CamareiraASerPromovida);

// Promova uma Recepcionista

var RecepcionistaASerPromovida = new Recepcionista{
    Nome = "Amanda Vasconcelos",
    CPF = "012365678945"
};
rh.PromverParaGerente(RecepcionistaASerPromovida);




System.Console.WriteLine();