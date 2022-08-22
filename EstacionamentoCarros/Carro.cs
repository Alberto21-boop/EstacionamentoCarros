using System;

namespace EstacionamentoCarros;

public class Carro
{
    public string NomeCarro { get; set; } = default!;
    public string Cor { get; set; } = default!;
    public int AnoCarro { get; set; }
   
    public string PegarNomeDoCarro()
    {
        return NomeCarro;
    }
    public string PegarCorDoCarro()
    {
        return Cor;
    }
    public int PegarOanoDoCarro()
    {
        return AnoCarro;
    }
    

}