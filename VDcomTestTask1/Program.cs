using VDcomTestTask1.Entities;
using VDcomTestTask1.Repositories;

namespace VDcomTestTask1 
{
    class Program 
    {
        static void Main(string[] args) 
        {
            ContractRepository contractRepository = new ContractRepository();
            IndividualRepository individualRepository = new IndividualRepository();

            var contracts = contractRepository.SelectCurrentYearContract();

            Console.WriteLine("Суммы всех заключенных договоров за текущий год:");
            foreach (decimal contractSum in contracts)
            {
                Console.WriteLine(contractSum);
            }
            Console.WriteLine();

            contracts = contractRepository.SelectContractByRussianLegal();

            Console.WriteLine("Суммы всех заключенных договоров по каждому контрагенту из России:");
            foreach (decimal contractSum in contracts) 
            {
                Console.WriteLine(contractSum);
            }
            Console.WriteLine();

            var emails = individualRepository.SelectIndividualEmails();
            Console.WriteLine("Список e-mail уполномоченных лиц, заключивших договора за последние 30 дней, на сумму больше 40000:");
            foreach (string email in emails)
            {
                Console.WriteLine(email);
            }

            Console.WriteLine();
        }
    }
}