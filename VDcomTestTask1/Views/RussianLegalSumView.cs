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
            
            Console.WriteLine("\nСуммы всех заключенных договоров по каждому контрагенту из России:");
            
            foreach (decimal sum in contractSums) 
            {
                Console.WriteLine($"{++sumCounter}. {sum}");
            }

            Console.WriteLine("\nНажмите любую клавишу, чтобы вернуться к выбору команд...");
            Console.ReadKey();
            Console.Clear();
        }
    }
}
