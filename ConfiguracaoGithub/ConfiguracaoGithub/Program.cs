using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
namespace ConfiguracaoGithub
{
    class Program
    {
        public string nome { get; set; }
        public int idade { get; set; }
        public double salario { get; set; }

        static void Main(string[] args)
        {
            double antigoSalario;
            Console.WriteLine("Hello World");
            Console.Write("Digite o Salário");
            antigoSalario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("O antigo salário é: " + antigoSalario.ToString("F2", CultureInfo.InvariantCulture));


        }
    }
}
