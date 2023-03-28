namespace ModuleSeventeen
{
    public interface IInterest<T> where T : Account
    {
        public void CalculateInterest(T account);
    }
}
