internal class Program
{
    static CaixaEletronico caixaEletronico = new CaixaEletronico();

    private static void Main(string[] args)
    {
        caixaEletronico.OnSaldoInsuficiente += 
        new Logo().MostrarBanner();

        while (true)
        {
            MostrarMenu();

            if (int.TryParse(Console.ReadLine(), out int escolha))
            {
                ExecutarEscolha(escolha);
            }
            else
            {
                Console.WriteLine("Opção inválida. Tente novamente.");
            }
        }

    }

    static void MostrarMenu()
    {
        Console.WriteLine("\nEscolha uma opção:");
        Console.WriteLine();
        Console.WriteLine("1. Saldo");
        Console.WriteLine("2. Depositar valores");
        Console.WriteLine("3. Sacar valores");
        Console.WriteLine("4. Extrato");
        Console.WriteLine("5. Depositar e obter saldo");
        Console.WriteLine("6. Sacar e obter saldo");
        Console.WriteLine("7. Aplicar Na Poupança e saldo");
        Console.WriteLine();
        Console.Write("Digite o número da opção desejada: ");
    }

    static void ExecutarEscolha(int escolha)
    {
        switch (escolha)
        {
            case 1:
                Saldo();
                break;
            case 2:
                Depositar();
                break;
            case 3:
                Sacar();
                break;
            case 4:
                Extrato();
                break;
            case 5:
                DepositaESaldo();
                break;
            case 6:
                SacaESaldo();
                break;
            case 7:
                AplicarPoupanca();
                break;
            default:
                Console.WriteLine("Opção inválida. Tente novamente.");
                break;
        }
    }

    delegate void ConsultaBancaria();
    delegate void TransacaoBancaria(decimal valor);

    private static void Saldo()
    {
        //caixaEletronico.Saldo();
        ExecutarConsultaBancaria(caixaEletronico.Saldo);
    }

    private static void Depositar()
    {
        //  caixaEletronico.Depositar(100);
        ExecutarTransacaoBancaria(caixaEletronico.Depositar, 100);
        // caixaEletronico.Depositar(40);
        ExecutarTransacaoBancaria(caixaEletronico.Depositar, 40);
        // caixaEletronico.Depositar(25);
        ExecutarTransacaoBancaria(caixaEletronico.Depositar, 25);
    }

    private static void DepositaESaldo()
    {
        TransacaoBancaria transacao = delegate (decimal valor)
        {
            caixaEletronico.Depositar(valor);
            caixaEletronico.Saldo();
        };

        transacao(100);
        transacao(40);
        transacao(25);
    }

    private static void AplicarPoupanca()
    {
        TransacaoBancaria depositar = caixaEletronico.Depositar;
        depositar(50);
        Console.WriteLine("Delegate 'depositar' executado com sucesso!");
        Console.WriteLine();

        TransacaoBancaria aplicar = caixaEletronico.AplicarPoupanca;
        aplicar(50);
        Console.WriteLine("Delegate 'aplicar' executado com sucesso!");
        Console.WriteLine();

        TransacaoBancaria saldo = delegate(decimal valor) { caixaEletronico.Saldo(); };
        saldo(50);
        Console.WriteLine("Delegate 'saldo' executado com sucesso!");
        Console.WriteLine();

        TransacaoBancaria depositarAplicarSaldo = depositar + aplicar + saldo;
        depositarAplicarSaldo(50);
        Console.WriteLine("Delegate multicast 'depositarAplicarSaldo' executado com sucesso!");
        Console.WriteLine();

        TransacaoBancaria aplicarSaldo = depositarAplicarSaldo - depositar;
        aplicarSaldo(50);
        Console.WriteLine("Delegate multicast 'aplicarSaldo' executado com sucesso!");
        Console.WriteLine();
    }

    private static void Sacar()
    {
        //caixaEletronico.Sacar(50);
        ExecutarTransacaoBancaria(caixaEletronico.Sacar, 50);
        //caixaEletronico.Sacar(20);
        ExecutarTransacaoBancaria(caixaEletronico.Sacar, 20);
    }

    private static void SacaESaldo()
    {
        TransacaoBancaria transacao = delegate (decimal valor)
        {
            caixaEletronico.Sacar(valor);
            caixaEletronico.Saldo();
        };

        transacao(50);
        transacao(20);
    }

    private static void Extrato()
    {
        //caixaEletronico.Extrato();
        ExecutarConsultaBancaria(caixaEletronico.Extrato);
    }

    private static void ExecutarConsultaBancaria(ConsultaBancaria consultaBancaria)
    {
        consultaBancaria();
    }

    private static void ExecutarTransacaoBancaria(TransacaoBancaria transacaoBancaria, decimal valor)
    {
        transacaoBancaria(valor);
    }

    private static void CaixaEletronico_OnSaldoInsuficiente(object? sender, SaldoInsuficienteEventArgs e)
    { 
        
    }
}