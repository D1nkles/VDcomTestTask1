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

            Console.Write("\nВведите название для файла отчета: ");
            fileName = Console.ReadLine();
            reportBuilder.BuildIndividualReport(individualRepository.SelectIndividualReportData(), fileName);
            
            Console.WriteLine("Отчет должен появиться в директории приложения.\n");

            Console.WriteLine("\nНажмите любую клавишу, чтобы вернуться к выбору команд...");
            Console.ReadKey();
            Console.Clear();
        }
    }
}
