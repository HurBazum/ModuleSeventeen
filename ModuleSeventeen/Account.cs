namespace ModuleSeventeen
{
    public abstract class Account
    {
        public string Type { get; protected set; }
        public double Balance { get; private set; }
        public double Interest { get; protected set; }

        protected Account(string type) 
        {
            Type = type;
        }

        public void AddBalance(double add)
        { 
            Balance += add;
        }
        public override string ToString()
        {
            return $"Type: {Type}\nBalance: {Balance}\nInterest: {Interest}";
        }
    }
}