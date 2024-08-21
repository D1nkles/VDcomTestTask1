using System.Threading.Channels;

namespace VDcomTestTask1.Views
{
    internal class MainView : IView
    {
        public void Show()
        {
            Console.WriteLine("Добро пожаловать в консольное приложение, взаимодействующее с базой данных!\n");

            Console.WriteLine("Список доступных в приложении команд:\n" +
                              "1. Вывести сумму всех заключенных договоров за текущий год.\n" +
                              "2. Вывести сумму заключенных договоров по каждому контрагенту из России.\n" +
                              "3. Вывести список e-mail уполномоченных лиц, заключивших договора за последние 30 дней, на сумму больше 40000.\n" +
                              "4. Изменить статус договора на \"Расторгнут\" для физических лиц, у которых есть действующий договор, " +
                              "и возраст которых старше 60 лет включительно.\n" +
                              "5. Создать отчет(текстовый файл в формате json) содержащий ФИО, e-mail, моб. телефон, дату рождения физ. лиц, " +
                              "у которых есть действующие договора по компаниям, расположенных в городе Москва.\n" +
                              "0. Закрыть приложение.\n");

            Console.Write("Введите номер команды, которую хотите выполнить: ");

            switch (Console.ReadLine()) 
            {
                case "1":
                    Program.currentYearSumView.Show();
                    break;

                case "2":
                    Program.russianLegalSumView.Show();
                    break;

                case "3":
                    Program.individualEmailView.Show();
                    break;

                case "4":
                    Program.updateContractStatusView.Show();
                    break;

                case "5":
                    Program.buildReportView.Show();
                    break;

                case "0":
                    Environment.Exit(0);
                    break;

                default:
                    Console.WriteLine("Команда не найдена. Нажмите любую клавишу, чтобы попробовать снова...");
                    Console.ReadKey();
                    Console.Clear();
                    break;
            }
                
        }
    }
}
