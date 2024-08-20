using VDcomTestTask1.Repositories;

namespace VDcomTestTask1.Views
{
    internal class BuildReportView : IView
    {
        IndividualRepository individualRepository;
        ReportBuilder reportBuilder;
        public BuildReportView(IndividualRepository individualRepository, ReportBuilder reportBuilder) 
        {
            this.individualRepository = individualRepository;
            this.reportBuilder = reportBuilder;
        }
        public void Show()
        {
            string fileName;

            Console.Write("Введите название для файла отчета: ");
            fileName = Console.ReadLine();
            reportBuilder.BuildIndividualReport(individualRepository.SelectIndividualReportData(), fileName);
            
            Console.WriteLine("Запрошенный файл должен появиться в директории приложения.\n");
        }
    }
}
