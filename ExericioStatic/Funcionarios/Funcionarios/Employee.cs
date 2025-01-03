using System.Globalization;

namespace Funcionarios
{
    class Employee
    {
        public int Id { get; private set; }
        public string ?Name { get; set; }
        public double Salario { get; set; }

        public Employee() { }

        public Employee(int id, string name, double salario)
        {
            Id = id;
            Name = name;
            Salario = salario;
        }

        public void AumentarSalario(double porcetagem)
        {
            Salario += (Salario * porcetagem);
        }

        public override string ToString()
        {
            return Id + ", " + Name +", " + Salario.ToString("F2",CultureInfo.InvariantCulture);
        }
    }
}
