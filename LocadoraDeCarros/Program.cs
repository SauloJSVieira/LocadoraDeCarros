using LocadoraDeCarros.Entities;
using LocadoraDeCarros.Services;
using System.Globalization;

namespace LocadoraDeCarros
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\nInsira os dados para Locação do veículo\n");
            Console.Write("Modelo do carro: "); string nomeModelo = Console.ReadLine();
            Console.Write("Retirada: "); DateTime retirada = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);
            Console.Write("Devolução: "); DateTime devolucao = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);
            Console.Write("Preço por hora: "); double precoHora = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Preço da diária: "); double precoDiaria = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            AluguelDeCarros alugarCarro = new AluguelDeCarros(retirada, devolucao, new Veiculo(nomeModelo));
            AluguelDoServico aluguelDoServico = new AluguelDoServico(precoHora, precoDiaria);
            aluguelDoServico.ProcessarFatura(alugarCarro);

            Console.WriteLine("\nFATURA:\n" + alugarCarro.Fatura);
        }
    }
}