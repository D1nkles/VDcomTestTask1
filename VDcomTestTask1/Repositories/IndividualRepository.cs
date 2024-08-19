using Microsoft.EntityFrameworkCore;
using VDcomTestTask1.Entities;

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
                            .ToList();

                return emailList;                                     
            }
        }
    }
}
