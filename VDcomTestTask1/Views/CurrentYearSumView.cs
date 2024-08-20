using VDcomTestTask1.Repositories;

namespace VDcomTestTask1.Views
{
    internal class CurrentYearSumView : IView
    {
        ContractRepository contractRepository;
        public CurrentYearSumView(ContractRepository contractRepository) 
        {
            this.contractRepository = contractRepository;
        }

        public void Show() 
        {
            int sumCounter = 0;
            var contractSums = contractRepository.SelectCurrentYearContract();

            Console.WriteLine("Суммы всех заключенных договоров за текущий год:");
            
            foreach(decimal sum in contractSums) 
            {
                Console.WriteLine($"{++sumCounter}. {sum}");
            }

            Console.WriteLine();
        }
    }
}
