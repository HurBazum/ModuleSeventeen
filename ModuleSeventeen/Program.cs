namespace ModuleSeventeen
{
    class Program
    {
        static void Main(string[] args)
        {
            CommonAccount common = new();
            common.AddBalance(500);
            Console.WriteLine(common.ToString());

            Console.WriteLine("\n*********************************************\n");

            SalaryAccount salary = new();
            salary.AddBalance(500);
            Console.WriteLine(salary.ToString());

            Console.ReadLine();
        }
    }
}