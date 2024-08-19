using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System.Linq.Expressions;
using VDcomTestTask1.Entities;

namespace VDcomTestTask1.Repositories
{
    internal class ContractRepository
    {
        public List<decimal> SelectCurrentYearContract() 
        {
            string currentYear = DateTime.Now.Year.ToString();

            using (var db = new ApplicationContext()) 
            {
                var currentYearContracts = db.Contracts
                                           .Where(c => c.ContractDate.ToString().Contains(currentYear))
                                           .Select(c => c.ContractSum)
                                           .ToList();
                
                return currentYearContracts;
            }
        }

        public List<decimal> SelectContractByRussianLegal() 
        {
            string countryName = "Россия";
            using (var db = new ApplicationContext()) 
            {
                var contractSums = db.Contracts
                                   .Where(c => c.LegalEntity.Country == countryName)
                                   .Select(c => c.ContractSum) 
                                   .ToList();
                
                return contractSums;
            }
        }

        public int UpdateContractStatus() 
        {
            int ageCap = 60;

            using (var db = new ApplicationContext()) 
            {
                string newStatus = "Расторгнут";
                var selectedContracts = db.Contracts
                                        .Where(c => c.IndividualEntity.Age >= ageCap
                                        && (c.ContractStatus != newStatus
                                        || c.ContractStatus != "Отменён"
                                        || c.ContractStatus != "Выполнен"))
                                        .ToList();

                if (!selectedContracts.IsNullOrEmpty()) 
                {
                    foreach(ContractEntity contract in selectedContracts) 
                    {
                        contract.ContractStatus = newStatus;
                    }

                    db.SaveChanges();
                    return selectedContracts.Count;
                }

                return selectedContracts.Count;
            }
        }
    }
}
