using System;

class Program
{
    static int[] V = new int[10]; // Declare V fora das funções para que seja acessível em todo o programa

    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("Esse programa faz o cálculo de atividades feitas em teste de mesa em C#.");
            Console.WriteLine("Tendo em mente que de 1 a 3 o programa calcula vetores,");
            Console.WriteLine("de 4 a 8 juros compostos, sabendo que o Exercício 6 calcula com base nos dados inseridos por você,");

            Console.WriteLine("Digite o número do exercício que deseja visualizar (1 a 8), ou 0 para sair.");
            int escolha = Convert.ToInt32(Console.ReadLine());

            if (escolha == 0)
            {
                Console.WriteLine("Saindo do programa...");
                break;
            }

            switch (escolha)
            {
                case 1:
                    Exercicio1();
                    break;
                case 2:
                    Exercicio2();
                    break;
                case 3:
                    Exercicio3();
                    break;
                case 4:
                    Exercicio4();
                    break;
                case 5:
                    Exercicio5();
                    break;
                case 6:
                    Exercicio6();
                    break;
                case 7:
                    Exercicio7();
                    break;
                case 8:
                    Exercicio8();
                    break;
                case 9:
                    
                    break;
                default:
                    Console.WriteLine("Exercício inválido. Por favor, escolha um número de 1 a 8.");
                    break;
            }
        }
    }

    static void Exercicio1()
    {
        int a = 111;
        int b = 40;
        float c = (a + b) / 2.0f;
        c = c - 40;

        V[2] = a + b + (int)c; // Converta 'c' de volta para int antes de somar

        Console.WriteLine("Executando o Exercício 1...");
        Console.WriteLine("O Exercício 1 calcula a seguinte equação:");
        Console.WriteLine("a = 111;");
        Console.WriteLine("b = 40;");
        Console.WriteLine("c = (a + b) / 2;");
        Console.WriteLine("c = c - 40;");
        Console.WriteLine("v[2] = a + b + c;");

        Console.WriteLine("O resultado da primeira equação é: " + V[2]);
    }

    static void Exercicio2()
    {
        int a = 4;
        while (a < 10)
        {
            V[a] = 10 * a;
            a += 1;
        }

        Console.WriteLine("Executando o Exercício 2...");
        Console.WriteLine("O Exercício 2 calcula a seguinte equação:");
        Console.WriteLine("a = 4;");
        Console.WriteLine("Enquanto (a < 10) {");
        Console.WriteLine("    V[a] = 10 * a;");
        Console.WriteLine("    a += 1;");
        Console.WriteLine("}");

        Console.WriteLine("O resultado da segunda equação é: ");
        for (int m = 4; m < 10; m++)
        {
            Console.WriteLine("V[" + m + "] = " + V[m]);
        }
    }

    static void Exercicio3()
    {
        int a = 9;
        int b = (a - 6);

        while (b < a)
        {
            V[b] = b + a;
            b = b + 2;
        }
        Console.WriteLine("O Exercício 3 calcula a seguinte equação:");
        Console.WriteLine("a = 9;");
        Console.WriteLine("b = a - 6;");
        Console.WriteLine("Enquanto (b < a) {");
        Console.WriteLine("    v[b] = b + a;");
        Console.WriteLine("    b = b + 2;");
        Console.WriteLine("}");
        Console.WriteLine("O resultado da terceira equação é:");

        for (int e = 3; e < 9 && e < V.Length; e += 2)
        {
            Console.WriteLine("V[" + e + "] = " + V[e]);
        }
    }

    static void Exercicio4()
    {
        Console.WriteLine("O Exercício 4 calcula juro composto.");
        Console.WriteLine("No exemplo, um investimento de R$ 800,00 é feito com uma taxa de 6% ao mês durante 4 meses.");

        double valorP = 800;
        double taxa = 0.06;
        int meses = 4;

        double valorF = valorP * Math.Pow((1 + taxa), meses);

        Console.WriteLine($"O valor final do investimento após {meses} meses é: R$ {valorF.ToString("N2")}");
    }

    static void Exercicio5()
    {
        double valorP = 2500;
        double taxa = 0.015;
        double tempo = 6;

        Console.WriteLine("Este Exercício calcula um investimento e o mostra em formato de tabela.");
        Console.WriteLine("Os dados do investimento seriam:");
        Console.WriteLine($"Capital de R$: {valorP.ToString("N2")}");
        Console.WriteLine($"Taxa de {taxa * 100}% ao mês");
        Console.WriteLine($"Durante {tempo} meses");

        for (int mes = 1; mes <= tempo; mes++)
        {
            double rendimentoM = valorP * Math.Pow((1 + taxa), mes);
            double liquido = rendimentoM - valorP;
            valorP += liquido;

            Console.WriteLine("|____________________________________________________________|");
            Console.WriteLine("|   MES    |   TAXA    |   CAPITAL  | R.LIQUIDO |   RENDA    |");
            Console.WriteLine("|____________________________________________________________|");
            Console.WriteLine($"|    {mes}     |   {taxa}   |  {valorP.ToString("N2")}  |  {liquido.ToString("N2")} |   {rendimentoM.ToString("N2")}   |");
        }
    }

    static void Exercicio6()
    {
        Console.WriteLine("Este programa calcula juro composto com base nos dados inseridos por você.");

        Console.WriteLine("Digite o valor de Capital investido:");
        double capital = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Digite a taxa de juros anual (em números decimais):");
        double taxaAnual = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Insira o período de tempo do investimento (em anos):");
        int anos = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("O resultado do cálculo do juro composto é:");

        double montante = CalculoMontante(capital, taxaAnual, anos);

        Console.WriteLine($"Montante após {anos} anos: R$ {montante.ToString("N2")}");
    }

    static double CalculoMontante(double capital, double taxa, int anos)
    {
        return capital * Math.Pow(1 + taxa, anos);
    }

    static void Exercicio7()
    {
        //declaração de variaveis
        double capital = 4100;
        double taxa = 0.05;
        int meses2 = 1;
        double ResultadoFinal = 0;
        double liquido = 0;
        double valorFinal = capital;
        //realiza a soma
        for (int mes = 1; mes < 7; mes++)
        {

            if (mes == 5)
            {
                ResultadoFinal = capital * Math.Pow((1 + taxa), meses2);
                meses2 = 1;
                valorFinal -= 1000;
                liquido = ResultadoFinal - capital;
                capital = valorFinal + (ResultadoFinal - capital);
            }
            else
            {
                ResultadoFinal = capital * Math.Pow((1 + taxa), meses2);
                liquido = ResultadoFinal - capital;
            }
            meses2 += 1;

            valorFinal += liquido;
            Console.WriteLine("Esse programa calcula um investimento com resgate e mostra o resultado em forma de tabela:");
            Console.Write("____________________________________________________________________________________________");
            Console.Write("\n|valor presente|taxa de juros|periodo a.m|rendimento|renda liquida|renda acumulada|resgate  |");
            Console.Write($"\n|______________|_____________|___________|__________|_____________|_______________|_________|");
            Console.Write($"\n|{capital.ToString("N2")}      |    {taxa.ToString("N2")}     |    {mes.ToString("N2")}   | {ResultadoFinal.ToString("N2")} |   {liquido.ToString("N2")}    |    {valorFinal.ToString("N2")}   |   {meses2}     |");
            Console.WriteLine("\n|___________________________________________________________________________________________|");
        }
    }

    static void Exercicio8()
    {
        double VP;
        double VF = 7390.61;
        double periodo = 6;
        double taxa = 1.5 / 100;

        double calculo()
        {
            return VP = VF / Math.Pow((1 + taxa), periodo);
        }
        Console.WriteLine("Esse programa calcula um investimento com resgate descobrindo os valores com base no valor futuro:");
        Console.WriteLine($"Valor presente: " + calculo().ToString("N2"));
        Console.WriteLine("taxa: " + taxa * 100 + "%");
        Console.WriteLine("periodo: " + periodo + " Anos");
        Console.WriteLine("Valor Final: " + VF.ToString("N2"));
    }
}
