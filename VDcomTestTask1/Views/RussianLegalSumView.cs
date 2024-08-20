using VDcomTestTask1.Repositories;

namespace VDcomTestTask1.Views
{
    internal class RussianLegalSumView : IView
    {
        ContractRepository contractRepository;
        public RussianLegalSumView(ContractRepository contractRepository)
        {
            this.contractRepository = contractRepository;
        }

        public void Show()
        {
            int sumCounter = 0;
            var contractSums = contractRepository.SelectContractByRussianLegal();
            
            Console.WriteLine("Суммы всех заключенных договоров по каждому контрагенту из России:");
            
            foreach (decimal sum in contractSums) 
            {
                Console.WriteLine($"{++sumCounter}. {sum}\n");
            }
        }
    }
}
