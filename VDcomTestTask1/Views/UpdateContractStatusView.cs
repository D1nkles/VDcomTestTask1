using System.Threading.Channels;
using VDcomTestTask1.Repositories;

namespace VDcomTestTask1.Views
{
    internal class UpdateContractStatusView : IView
    {
        ContractRepository contractRepository;
        public UpdateContractStatusView(ContractRepository contractRepository)
        {
            this.contractRepository = contractRepository;
        }

        public void Show() 
        {
            int updatedCount = contractRepository.UpdateContractStatus();

            Console.WriteLine($"\nКол-во измененных договоров: {updatedCount}\n");

            Console.WriteLine("\nНажмите любую клавишу, чтобы вернуться к выбору команд...");
            Console.ReadKey();
            Console.Clear();
        }

    }
}
