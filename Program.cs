class Program
{
    static void Main()
    {
        switch (Menu())
        {
            case 1: Sum(); break;
            case 2: Sub(); break;
            case 3: Mult(); break;
            case 4: Div(); break;
            default: Console.Clear(); System.Environment.Exit(0); break;
        }
    }

    static short Menu()
    {
        Console.Clear();
        Console.WriteLine("======= Calculadora 'Dois Valores' =======\n");

        Console.WriteLine("1 - Somar");
        Console.WriteLine("2 - Subtrair");
        Console.WriteLine("3 - Multiplicar");
        Console.WriteLine("4 - Dividir");
        Console.WriteLine("5 - Sair\n");

        Console.WriteLine("Escolha uma das opções:");
        short option = short.Parse(Console.ReadLine());

        Console.Clear();

        return option;
    }

    static float[] GetOperationValues()
    {
        float[] values = new float[2];

        Console.WriteLine("Digite o primeiro valor:");
        values[0] = float.Parse(Console.ReadLine());
        Console.WriteLine("Digite o segundo valor:");
        values[1] = float.Parse(Console.ReadLine());
        Console.WriteLine("");

        return values;
    }

    static void Sum()
    {
        Console.WriteLine("======= Operação Soma =======\n");

        float[] values = GetOperationValues();
        float result;

        result = values[0] + values[1];

        Console.WriteLine($"O resultado é {result}");
        Console.ReadKey();
        Main();
    }
    static void Sub()
    {
        Console.WriteLine("======= Operação Subtração =======\n");

        float[] values = GetOperationValues();
        float result;

        result = values[0] - values[1];

        Console.WriteLine($"O resultado é {result}");
        Console.ReadKey();
        Main();
    }
    static void Mult()
    {
        Console.WriteLine("======= Operação Multiplicação =======\n");

        float[] values = GetOperationValues();
        float result;

        result = values[0] * values[1];

        Console.WriteLine($"O resultado é {result}");
        Console.ReadKey();
        Main();
    }
    static void Div()
    {
        Console.WriteLine("======= Operação Divisão =======\n");

        float[] values = GetOperationValues();
        float result;

        result = values[0] / values[1];

        Console.WriteLine($"O resultado é {result}");
        Console.ReadKey();
        Main();
    }
}