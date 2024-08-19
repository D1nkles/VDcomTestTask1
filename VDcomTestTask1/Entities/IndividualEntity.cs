using System.ComponentModel.DataAnnotations;

namespace VDcomTestTask1.Entities
{
    internal class IndividualEntity
    {
        public int Id { get; set; }
        [MaxLength(30)]
        public string FirstName { get; set; }
        [MaxLength(30)]
        public string Surname { get; set; }
        [MaxLength(30)]
        public string? SecondName { get; set; }
        public string Gender { get; set; }
        [Range(18, 100)]
        public int Age { get; set; }
        [MaxLength(100)]
        public string? Workplace { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public string Address { get; set; }
        [MaxLength(256)]
        public string? Email { get; set; }
        public long? PhoneNumber { get; set; }
        public DateOnly Birthday { get; set; }
    }
}
