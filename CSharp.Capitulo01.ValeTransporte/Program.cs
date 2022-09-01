using System;

namespace CSharp.Capitulo01.ValeTransporte
{
    class Program
    {
        static void Main(string[] args)
        {
            Inicio:

            Console.Write("Funcionário: ");
            var nome = Console.ReadLine();
            
            Console.Write("Salário: ");
            var salario = Convert.ToDecimal(Console.ReadLine()); // em C# a conversão de um tipo em outro é explícita.
            
            Console.Write("Gasto com transporte: ");
            var gastoComTransporte = Convert.ToDecimal(Console.ReadLine());

            var descontoMaximo = salario * 6 / 100; // é o mesmo que 6%.

            var descontoVT = gastoComTransporte > descontoMaximo ? descontoMaximo : gastoComTransporte;

            var resultado = $"\nFuncionário: {nome}\n" + 
                $"Salário: {salario:C}\n" +
                $"Desconto VT: {descontoVT:C}";

            Console.WriteLine(resultado);

            Console.WriteLine("\nPressione qualquer tecla para novo cálculo ou Esc para sair.");

            var comando  = Console.ReadKey();

            if (comando.Key == ConsoleKey.Escape)
            {
                Environment.Exit(0); // comando usado para fechar a aplicação.
            }

            Console.Clear();

            goto Inicio;
        }
    }
}