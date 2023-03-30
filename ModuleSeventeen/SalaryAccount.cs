namespace ModuleSeventeen
{
    public class SalaryAccount : Account, IInterest<SalaryAccount>
    {
        public SalaryAccount() : base("зарплатный")
        {

        }

        public void CalculateInterest(SalaryAccount salaryAccount)
        {
            salaryAccount.Interest = salaryAccount.Balance * 0.5;
        }

        public override string ToString()
        {
            CalculateInterest(this);
            return base.ToString();
        }
    }
}