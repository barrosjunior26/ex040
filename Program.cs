namespace ex040
{
    public class Program
    {
        public static void Main(String[] args)
        {
            double[] adicao, subtracao;
            int quantidade, opcao;
            double resultado;

            Console.Clear();

            Console.Write("Digite a opção desejada; \n1 - Operação de adição; \n2 - Operação de subtração; \n3 - Operação de multiplicação; \n4 - Operação de divisão; \n0 - Sair do sistema: ");
            while (!int.TryParse(Console.ReadLine(), out opcao))
            {
                Console.Clear();
                Console.WriteLine("\nOpção inválida.\nPor favor, tente novamente.\n");
                Console.Write("Digite a opção desejada;\n\n1 - Operação de adição; \n2 - Operação de subtração; \n3 - Operação de multiplicação; \n4 - Operação de divisão; \n0 - Sair do sistema: ");

            }

            switch (opcao)
            {
                case 0:
                    Console.Clear();
                    Console.Write("Saindo do sistema");
                    for (int i = 5; i > 0; i--)
                    {
                        Console.Write(".");
                        Thread.Sleep(1000);
                    }

                    Console.WriteLine("Até");

                    Environment.Exit(0);
                    break;
                case 1:
                    Console.Clear();
                    Console.WriteLine("\n\nOperação de adição\n");
                    Console.Write("Informe a quantidade de valores que deseja somar: ");
                    while (!int.TryParse(Console.ReadLine(), out quantidade))
                    {
                        Console.WriteLine("Valor digitado é incorreto.\nPor favor, tente novamente.");
                        Console.Write("\nInforme a quantidade de valores que deseja somar: ");
                    }

                    adicao = new double[quantidade];

                    for (int i = 0; i < adicao.Length; i++)
                    {
                        Console.Write($"Informe o {i + 1}º valor: ");
                        adicao[i] = Convert.ToDouble(Console.ReadLine());
                    }

                    resultado = adicao.Sum();

                    Console.WriteLine($"O resultado é = {Math.Round(resultado, 2)}");
                    break;
                case 2:
                    Console.Clear();
                    Console.WriteLine("\n\nOperação de subtração\n");
                    Console.Write("Informe a quantidade de valores que deseja subtrair: ");
                    while (!int.TryParse(Console.ReadLine(), out quantidade))
                    {
                        Console.Write("Valor digitado é incorreto.\nPor favor, tente novamente.");
                        Console.Write("\nInforme a quantidade de valores que deseja subtrair: ");
                    }

                    subtracao = new double[quantidade];

                    for (int i = 0; i < subtracao.Length; i++)
                    {
                        Console.Write($"Informe o {i + 1}º valor: ");
                        subtracao[i] = Convert.ToDouble(Console.ReadLine());
                    }

                    resultado = subtracao.Aggregate((valor1, valor2) => valor1 - valor2);

                    Console.WriteLine($"O resultado da operação é = {Math.Round(resultado, 2)}");
                    break;
                case 3:
                    Console.Clear();
                    Console.WriteLine("\n\nOperação de multiplicação\n");
                    Console.Write("Informe o primeiro valor: ");
                    double valor1 = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Informe o segundo valor: ");
                    double valor2 = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine($"O resultado da multiplicação é = {Math.Round(valor1 * valor2, 2)}");
                    break;
                case 4:
                    Console.Clear();
                    Console.WriteLine("\n\nOperação de divisão\n");
                    Console.Write("Informe o primeiro valor: ");
                    valor1 = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Informe o segundo valor: ");
                    valor2 = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine($"O resultado da divisão é = {Math.Round(valor1 / valor2, 2)}");
                    break;
            }
        }
    }
}