using System.Security.Principal;

namespace ModuleSeventeen
{
    public class CommonAccount : Account, IInterest<CommonAccount>
    {
        public CommonAccount() : base("обычный")
        {

        }

        public void CalculateInterest(CommonAccount commonAccount)
        {
            commonAccount.Interest = commonAccount.Balance * 0.4;
            if (commonAccount.Balance < 1000)
            {
                commonAccount.Interest -= commonAccount.Balance * 0.2;
                return;
            }
            if (commonAccount.Balance < 50000)
            {
                commonAccount.Interest -= commonAccount.Balance * 0.4;
            }
        }

        public override string ToString()
        {
            CalculateInterest(this);
            return base.ToString();
        }
    }
}