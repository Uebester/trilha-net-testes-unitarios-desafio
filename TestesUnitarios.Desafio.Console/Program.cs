using TestesUnitarios.Desafio.Console.Services;


ValidacoesLista lista = new ValidacoesLista();

var meu = new List<int> { 5, -1, -8, 9 };
var numeroParaProcurar = 9;

var resultado = lista.ListaContemDeterminadoNumero(meu, numeroParaProcurar);

Console.WriteLine(resultado);