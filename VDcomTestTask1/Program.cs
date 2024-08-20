using VDcomTestTask1.Repositories;

namespace VDcomTestTask1 
{
    class Program 
    {
        static void Main(string[] args) 
        {
            ContractRepository contractRepository = new ContractRepository();
            IndividualRepository individualRepository = new IndividualRepository();

            

            var reportData = individualRepository.SelectIndividualReportData();
            var reportBuilder = new ReportBuilder();
            reportBuilder.BuildIndividualReport(reportData, "report");
        }
    }
}