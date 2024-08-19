using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.SqlTypes;

namespace VDcomTestTask1.Entities
{
    internal class ContractEntity
    {
        public int Id { get; set; }
        public int LegalEntityId { get; set; }
        public int IndividualEntityId { get; set; }
        public decimal ContractSum { get; set; }
        [MaxLength(35)]
        public string ContractStatus { get; set; }
        public DateOnly ContractDate { get; set; }

        public LegalEntity LegalEntity { get; set; }
        public IndividualEntity IndividualEntity { get; set; }
    }
}
