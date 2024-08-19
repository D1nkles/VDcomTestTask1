using System.ComponentModel.DataAnnotations;

namespace VDcomTestTask1.Entities
{
    internal class ContractEntity
    {
        public int Id { get; set; }
        public int LegalEntityId { get; set; }
        public int IndividualEntityId { get; set; }
        public long ContractSum { get; set; }
        [MaxLength(35)]
        public string ContractStatus { get; set; }
        public DateOnly ContractDate { get; set; }
    }
}
