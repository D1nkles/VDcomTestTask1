﻿using VDcomTestTask1.Repositories;

namespace VDcomTestTask1.Views
{
    internal class IndividualEmailView : IView
    {
        IndividualRepository individualRepository;
        public IndividualEmailView(IndividualRepository individualRepository)
        {
            this.individualRepository = individualRepository;
        }

        public void Show()
        {
            int emailCounter = 0;
            var individualEmails = individualRepository.SelectIndividualEmails();

            Console.WriteLine("\nСписок e-mail уполномоченных лиц, заключивших договора за последние 30 дней, на сумму больше 40000:");

            foreach (string email in individualEmails) 
            {
                Console.WriteLine($"{++emailCounter}. {email}");
            }

            Console.WriteLine("\nНажмите любую клавишу, чтобы вернуться к выбору команд...");
            Console.ReadKey();
            Console.Clear();
        }
    }
}
