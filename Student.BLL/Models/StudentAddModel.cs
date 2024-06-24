namespace StudentExample.BLL.Models
{
    public class StudentAddModel
    {
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public long StudentNo { get; set; }
        public DateOnly Birthdate { get; set; }
    }
}
