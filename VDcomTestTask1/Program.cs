using VDcomTestTask1.Repositories;
using VDcomTestTask1.Views;

namespace VDcomTestTask1 
{
    class Program 
    {
        static ContractRepository contractRepository;
        static IndividualRepository individualRepository;
        static ReportBuilder reportBuilder;

        public static MainView mainView;
        public static CurrentYearSumView currentYearSumView;
        public static RussianLegalSumView russianLegalSumView;
        public static IndividualEmailView individualEmailView;
        public static UpdateContractStatusView updateContractStatusView;
        public static BuildReportView buildReportView;

        static void Main(string[] args) 
        {
            contractRepository = new ContractRepository();
            individualRepository = new IndividualRepository();
            reportBuilder = new ReportBuilder();

            mainView = new MainView();
            currentYearSumView = new CurrentYearSumView(contractRepository);
            russianLegalSumView = new RussianLegalSumView(contractRepository);
            individualEmailView = new IndividualEmailView(individualRepository);
            updateContractStatusView = new UpdateContractStatusView(contractRepository);
            buildReportView = new BuildReportView(individualRepository, reportBuilder);

            while (true) 
            {
                mainView.Show();
            }
        }
    }
}