using HOTELDOTNET.Models;

Pessoa p1 = new Pessoa("Taís", "Vidotto");
Pessoa p2 = new Pessoa("Tiago", "Vidotto");

List<Pessoa> pessoaList = [p1, p2];

Suite suite = new Suite("Premium", 1, 40.0M);

Suite suite2 = new Suite("Master", 3, 50.0M);

Reserva reserva = new Reserva(5);

reserva.CadastrarSuite(suite2);
reserva.CadastrarHospedes(pessoaList);

Console.WriteLine($"Hóspedes: {reserva.ObterQuantidadeHospedes()}");
Console.WriteLine($"Valor diária: {reserva.CalcularValorDiaria()}");
