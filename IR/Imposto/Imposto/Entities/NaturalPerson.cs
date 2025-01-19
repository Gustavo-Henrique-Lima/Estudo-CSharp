namespace Imposto.Entities
{
    class NaturalPerson : Person
    {
        public double HealthExpenses { get; set; }

        public NaturalPerson(string name, double annualIncome,  double healthExpenses)
            :base(name, annualIncome)
        {
            HealthExpenses = healthExpenses;
        }

        public override double CalculateTaxes()
        {
            if(AnnualIncome < 20000) {
                return (AnnualIncome * 0.15) - (HealthExpenses * 0.5);
            }
            else
            {
                return (AnnualIncome * 0.25) - (HealthExpenses * 0.5);
            }
        }
    }
}
