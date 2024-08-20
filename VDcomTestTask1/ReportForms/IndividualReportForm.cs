namespace VDcomTestTask1.ReportForms
{
    internal class IndividualReportForm
    {
        public string FirstName { get; set; }
        public string Surname { get; set; }
        public string? SecondName { get; set; }
        public string? Email { get; set; }
        public long? PhoneNumber { get; set; }
        public DateOnly Birthday { get; set; }
    }
}
