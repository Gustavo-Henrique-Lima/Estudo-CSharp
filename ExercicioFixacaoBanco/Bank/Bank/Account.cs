using System.Globalization;

namespace Bank
{
    class Account
    {
        public string Numero {  get; private set; } = string.Empty;
        public string Titular { get; set; } = string.Empty;
        public double Saldo {get ; internal set;}

        public Account()
        {
        }

        public Account(string numero, string titular)
        {
            Numero = numero;
            Titular = titular;
        }

        public Account(string numero, string titular, double depositoInicial) : this( numero , titular)
        {
            Depositar(depositoInicial);
        }

        public void Depositar(double valor)
        {
            Saldo += valor;
        }

        public void Sacar(double valor)
        {
            Saldo -= (valor + 5);
        }

        
        public override string ToString()
        {
            return $"Conta {Numero}, Titular: {Titular}, Saldo: $ {Saldo.ToString("F2",CultureInfo.InvariantCulture)}";
        }

    }
}
