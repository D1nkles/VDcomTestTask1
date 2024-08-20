using VDcomTestTask1.ReportForms;

namespace VDcomTestTask1.Repositories
{
    internal class IndividualRepository
    {
        public List<string> SelectIndividualEmails()
        {
            DateTime currentDate = DateTime.Now;
            decimal contractSumCap = 40000;

            using (var db = new ApplicationContext())
            {
                var emailList = db.Individuals
                                .Join(db.Contracts,
                                i => i.Id,
                                c => c.IndividualEntityId,
                                (i, c) =>
                                new
                                {
                                    i.Id,
                                    i.Email,
                                    c.ContractSum,
                                    c.ContractDate
                                }).Where(c => c.ContractDate <= currentDate
                                && c.ContractDate >= currentDate.AddDays(-30)
                                && c.ContractSum > contractSumCap)
                                .Select(i => i.Email)
                                .Distinct()
                                .ToList();

                return emailList;
            }
        }

        public List<IndividualReportForm> SelectIndividualReportData()
        {
            using (var db = new ApplicationContext())
            {
                string terminatedStatus = "Расторгнут";
                string canceledStatus = "Отменён";
                string completedStatus = "Выполнен";
                string cityName = "Москва";

                var selectedIndividuals = db.Individuals.Join(db.Contracts,
                                  i => i.Id,
                                  c => c.IndividualEntityId,
                                  (i, c) =>
                                  new
                                  {
                                      i.Id,
                                      i.FirstName,
                                      i.Surname,
                                      i.SecondName,
                                      i.Email,
                                      i.PhoneNumber,
                                      i.Birthday,
                                      c.ContractStatus,
                                      c.LegalEntity.City
                                  }).Where(f => f.City == cityName
                                  && (f.ContractStatus != terminatedStatus
                                  && f.ContractStatus != canceledStatus
                                  && f.ContractStatus != completedStatus))
                                  .Select(f => new IndividualReportForm
                                  {
                                      FirstName = f.FirstName,
                                      Surname = f.Surname,
                                      SecondName = f.SecondName,
                                      Email = f.Email,
                                      PhoneNumber = f.PhoneNumber,
                                      Birthday = f.Birthday
                                  })
                                  .Distinct()
                                  .ToList();

                return selectedIndividuals;
            }
        }
    }
}
