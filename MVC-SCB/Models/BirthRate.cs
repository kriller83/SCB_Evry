namespace MVC_SCB.Models
{
    public class BirthRate
    {
        public int BirthRateId { get; set; }
        public int Year { get; set; }
        public int Born { get; set; }

        public virtual Gender Gender { get; set; }
        public int GenderId { get; set; }
    }
}