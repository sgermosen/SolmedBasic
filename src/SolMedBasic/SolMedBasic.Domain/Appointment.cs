namespace SolMedBasic.Domain
{
    public class Appointment : BaseEntity
    {
        public DateTime Date { get; set; }
        public string Reason { get; set; }
    }
}
