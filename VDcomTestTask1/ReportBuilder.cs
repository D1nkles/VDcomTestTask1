using VDcomTestTask1.ReportForms;

namespace VDcomTestTask1
{
    internal class ReportBuilder
    {
        string fileFormat = ".json";
        string PATH = Directory.GetCurrentDirectory();

        public void BuildIndividualReport(List<IndividualReportForm> data, string fileName)
        {
            PATH = Path.Combine(PATH, fileName + fileFormat);

            if (File.Exists(PATH)) 
            {
                File.Delete(PATH);
            }

            using (FileStream fileStream = new FileStream(PATH, FileMode.OpenOrCreate))
            {
                using (StreamWriter writer = new StreamWriter(fileStream))
                {
                    writer.WriteLine("Имя        Фамилия        Отчество        e-mail        Номер телефона        Дата рождения\n");

                    foreach (IndividualReportForm report in data)
                    {
                        writer.WriteLine($"{report.FirstName}        {report.Surname}        {report.SecondName}        " +
                                         $"{report.Email}        {report.PhoneNumber}        {report.Birthday} ");
                    }
                }
            }
        }
    }
}
