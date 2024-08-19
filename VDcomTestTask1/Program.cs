using VDcomTestTask1.Entities;
using VDcomTestTask1.Repositories;

namespace VDcomTestTask1 
{
    class Program 
    {
        static void Main(string[] args) 
        {
            ContractRepository repository = new ContractRepository();
            var contracts = repository.SelectCurrentYearContract();

            Console.WriteLine("Суммы всех заключенных договоров за текущий год:");
            foreach (decimal contractSum in contracts)
            {
                Console.WriteLine(contractSum);
            }
             
            
        }
    }
}