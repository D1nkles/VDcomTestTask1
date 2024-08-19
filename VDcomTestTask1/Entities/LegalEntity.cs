using System.ComponentModel.DataAnnotations;

namespace VDcomTestTask1.Entities
{
    internal class LegalEntity
    {
        public int Id { get; set; }
        [MaxLength(100)]
        public string CompanyName { get; set; }
        public long TaxpayerIdentificationNumber { get; set; }
        public long PrimaryStateRegistrationNumber { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public string Address { get; set; }
        [MaxLength(256)]
        public string? Email { get; set; }
        public long? PhoneNumber { get; set; }

        public List<ContractEntity> Contracts { get; set; } = new List<ContractEntity>();
    }
}
