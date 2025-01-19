namespace Imposto.Entities
{
    class LegalPerson : Person
    {
        public int NumberEmployees { get; set; }

        public LegalPerson(string name, double annualIncome, int numberEmployees)
            : base(name, annualIncome)
        {
            NumberEmployees = numberEmployees;
        }

        public override double CalculateTaxes()
        {
            if (NumberEmployees < 10)
            {
                return AnnualIncome * 0.16;
            }
            else
            {
                return AnnualIncome * 0.14;
            }
        }
    }
}
