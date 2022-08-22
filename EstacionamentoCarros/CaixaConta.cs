using System;
namespace EstacionamentoCarros;

public class CaixaConta
{
    public double ValorEntrada { get; set; }
    public double ValorHorasAdicionais { get; set; }
    public double DinheiroRecebido { get; set; }
    public double ValorPagar { get; set; } 
    public double TotalHoras { get; set; }
    public double Troco { get; set; }
    public DateTime Entrada { get; set; } = default!;
    public DateTime Saida { get; set; } = default!;
    public TimeSpan TempoEstadia { get; set; }
 

    public double PassaOTrocoParaOcliente()
    {
        return Troco;
    }
    public double PegaODinhieroDoCliente()
    {
        return DinheiroRecebido;
    }
    public double SomarAsHorasAdicionais()
    {
        return ValorHorasAdicionais;
    }
    public double PegarOValorDeEntrada()
    {
        return ValorEntrada;
    }
    public double PegarValorParaPagamento()
    {
        return ValorPagar;
    }
    public DateTime PegarAEntradaNoEstacionamento()
    {
        return Entrada;
    }
    public DateTime PegarSaidaDoEstacionamento()
    {
        return Saida;
    }
    public TimeSpan PegarTempoNoPatio()
    {
        return TempoEstadia;
    }

}
