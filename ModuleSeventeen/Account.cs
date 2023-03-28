namespace ModuleSeventeen
{
    public abstract class Account
    {
        public string Type { get; protected set; }
        public double Balance { get; set; }
        public double Interest { get; protected set; }

        public Account(string type) 
        {
            Type = type;
        }

        public override string ToString()
        {
            return $"Type: {Type}\nBalance: {Balance}\nInterest: {Interest}";
        }
    }
}
