using VDcomTestTask1.ReportForms;

namespace VDcomTestTask1
{
    internal class ReportBuilder
    {
        string fileFormat = ".json";
        string space = "        ";
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
                    writer.WriteLine($"Имя{space}Фамилия{space}Отчество{space}e-mail{space}Номер телефона{space}Дата рождения\n");

                    foreach (IndividualReportForm report in data)
                    {
                        writer.WriteLine($"{report.FirstName}{space}{report.Surname}{space}{report.SecondName}{space}" +
                                         $"{report.Email}{space}{report.PhoneNumber}{space}{report.Birthday}");
                    }
                }
            }
        }
    }
}
