namespace ModuleSeventeen
{
    class Program
    {
        static void Main(string[] args)
        {
            CommonAccount common = new();
            common.Balance = 500;
            Console.WriteLine(common.ToString());
            Console.WriteLine("\n*********************************************\n");

            SalaryAccount salary = new();
            salary.Balance = 500;
            Console.WriteLine(salary.ToString());

            Console.ReadLine();
        }
    }
}