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

            Console.WriteLine($"Кол-во измененных договоров: {updatedCount}\n");
        }
    }
}
