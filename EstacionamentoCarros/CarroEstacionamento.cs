using EstacionamentoCarros;


Carro carro = new Carro();

Console.WriteLine("Oi Seja bem vindo ao estacionamento!");
Console.WriteLine("A entrada são R$ 10,00");
Console.WriteLine("E as demais horas são R$ 2,00");

Console.WriteLine("Digite o nome do carro");
carro.NomeCarro = Console.ReadLine();
Console.WriteLine("Agora entre com a cor do carro");
carro.Cor = Console.ReadLine();
Console.WriteLine("Qual o ano do carro ?");
carro.AnoCarro = int.Parse(Console.ReadLine());


CaixaConta caixaconta = new CaixaConta();

caixaconta.ValorEntrada = 10.00;
caixaconta.ValorHorasAdicionais = 2.00;

Console.WriteLine("Hoario da entrada do veiculo no patio");
caixaconta.Entrada = DateTime.Parse(Console.ReadLine());
Console.WriteLine("Horario da saida do veiculo do patio");
caixaconta.Saida = DateTime.Parse(Console.ReadLine());


caixaconta.TempoEstadia = caixaconta.Saida - caixaconta.Entrada;
caixaconta.TotalHoras = caixaconta.TempoEstadia.TotalHours;
Console.WriteLine("Seu carro ficou aqui por = " + caixaconta.TempoEstadia.TotalHours + " horas");
//caixaconta.TotalHoras = caixaconta.TempoEstadia * caixaconta.ValorHorasAdicionais; //- caixaconta.ValorHorasAdicionais + caixaconta.ValorEntrada;
//caixaconta.ValorPagar = caixaconta.TotalHoras - caixaconta.ValorHorasAdicionais + caixaconta.ValorEntrada;
//caixaconta.Compra = caixaconta.Tempo.TimeSpan.TotalSeconds(caixaconta.Compra);

//caixaconta.ValorPagar = caixaconta.Compra - caixaconta.ValorHorasAdicionais + caixaconta.ValorEntrada;

double resultado = caixaconta.ValorEntrada + ((caixaconta.TotalHoras - 1) * caixaconta.ValorHorasAdicionais);

if (caixaconta.TempoEstadia.TotalHours == 1 || caixaconta.TempoEstadia.TotalHours < 1)
{
    Console.WriteLine("Seu carro ficou aqui por = " + caixaconta.TempoEstadia.TotalHours + " horas");
    Console.WriteLine("O Valor do estacionamento é de R$10,00");
}
else if (caixaconta.TempoEstadia.TotalHours != 1)
{
    
    Console.Write("O valor do estacionamento fico em  = R$" + resultado.ToString("C"));

}

Console.WriteLine();
Console.WriteLine("Digite o valor que você vai depositar para pagar o estacionamento:");
caixaconta.DinheiroRecebido = double.Parse(Console.ReadLine());

caixaconta.Troco = caixaconta.DinheiroRecebido - resultado;




string[] lines = {"CUPOM FISCAL", "", "Nome Do Carro = " + carro.PegarNomeDoCarro(), "Cor do Carro = " + carro.PegarCorDoCarro(), "Ano do Carro = " + 
        carro.PegarOanoDoCarro(), "Hora de Entrada do carro = " + caixaconta.PegarAEntradaNoEstacionamento(), "Horario da Saida do Carro = " 
        + caixaconta.PegarSaidaDoEstacionamento(), "Seu carro ficou em nosso estacionamento por = " + caixaconta.PegarTempoNoPatio()
         ,"Valor do Estacionamento = " + resultado.ToString("C"),"Valor do Pagamento = " + caixaconta.PegaODinhieroDoCliente().ToString("C"), 
          "Seu troco é de = " + caixaconta.PassaOTrocoParaOcliente().ToString("C"), "", "OBRIGADO VOLTE SEMPRE"};

string docPath = @"C:\Users\alber\Desktop\Imprimir";

using (StreamWriter outputFile = new StreamWriter(Path.Combine(docPath, "WriteLines.txt")))
{
    foreach (string line in lines)
        outputFile.WriteLine(line);
}

